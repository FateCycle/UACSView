using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using UACSPopupForm;

namespace UACSControls
{
    public partial class conCrane : UserControl
    {
        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDataProvider = null;
        private Baosight.iSuperframe.Authorization.Interface.IAuthorization auth = null;
        public conCrane()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲   
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }    
        private  Label lblCraneNo = new Label();
        private bool isCraneLbl = false;
        private CraneStatusBase cranePLCStatusBase = new CraneStatusBase();

        //step1
        public void InitTagDataProvide(string tagServiceName)
        {
            try
            {
                tagDataProvider.ServiceName = tagServiceName;
            }
            catch (Exception ex)
            {
            }
        }


        private string craneNO = string.Empty;
        //step2
        public string CraneNO
        {
            get { return craneNO; }
            set
            {
                craneNO = value;
            }
        }

        //step3
        public delegate void RefreshControlInvoke(CraneStatusBase _cranePLCStatusBase, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, long craneWith, Panel panel);

        public void RefreshControl(CraneStatusBase _cranePLCStatusBase, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown,long craneWith,Panel panel)
        {
            try
            {
                cranePLCStatusBase = _cranePLCStatusBase;
                //计算X方向上的比例关系
                double xScale = Convert.ToDouble(panelWidth) / Convert.ToDouble(baySpaceX);

                //计算控件行车中心X，区分为X坐标轴向左或者向右
                double X = 0;
                double location_Crane_X = 0;
                double location_Crab_X = 0;
                if (xAxisRight == true)
                {
                    X = Convert.ToDouble(_cranePLCStatusBase.XAct) * xScale;
                    location_Crane_X = Convert.ToDouble(_cranePLCStatusBase.XAct - craneWith / 2) * xScale;
                    location_Crab_X = 0;//在行车panel内，所以永远为0
                }
                else
                {
                    X = (Convert.ToDouble(baySpaceX) - Convert.ToDouble(_cranePLCStatusBase.XAct)) * xScale;
                    location_Crane_X = Convert.ToDouble( baySpaceX - (_cranePLCStatusBase.XAct + craneWith / 2)) * xScale;
                    location_Crab_X = 0;//在行车panel内，所以永远为0
                }

                //计算Y方向的比例关系
                double yScale = Convert.ToDouble(panelHeight) / Convert.ToDouble(baySpaceY);

                //计算行车中心Y 区分Y坐标轴向上或者向下
                double Y = 0;
                double location_Crane_Y = 0;
                double location_Crab_Y = 0;
                if (yAxisDown == true)
                {
                    Y = Convert.ToDouble(_cranePLCStatusBase.YAct) * yScale;
                    location_Crane_Y = 0;
                    location_Crab_Y = Y - panelCrab.Height / 2;
                }
                else
                {
                    Y = (Convert.ToDouble(baySpaceY) - Convert.ToDouble(_cranePLCStatusBase.YAct)) * yScale;
                    location_Crane_Y = 0;
                    location_Crab_Y = Y - panelCrab.Height / 2;
                }




                //修改行车大车控件的宽度和高度
                this.Width = Convert.ToInt32(craneWith * xScale);
                this.Height = panelHeight;//大车的高度直接等于panel的高度

                //定位大车的坐标
                this.Location = new Point(Convert.ToInt32(location_Crane_X), Convert.ToInt32(location_Crane_Y));


                //修改小车的宽度
                panelCrab.Width = this.Width;

                //定位小车的坐标
                panelCrab.Location = new Point(Convert.ToInt32(location_Crab_X), Convert.ToInt32(location_Crab_Y));
                panelCrab.BringToFront();

                //无卷显示无卷标记
                if (_cranePLCStatusBase.HasCoil == 0)
                {
                    this.panelCrab.BackgroundImage = global::UACSControls.Resource1.imgCarNoCoil;
                }
                //有卷显示有卷标记
                else if (_cranePLCStatusBase.HasCoil == 1)
                {
                    this.panelCrab.BackgroundImage = global::UACSControls.Resource1.imgCarCoil;
                }

                this.BringToFront();
            }
            catch (Exception ex)
            {
                LogManager.WriteProgramLog(ex.Message);
                LogManager.WriteProgramLog(ex.StackTrace);
            }
        }

        private void panelCrane_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawString(cranePLCStatusBase.CraneNO.ToString(), 
                new Font("微软雅黑", 10, FontStyle.Bold), 
                Brushes.White, new Point(5, this.Height - 20));

        }

        private void ToolStrip_DelCraneOrder_Click(object sender, EventArgs e)
        {
            if (cranePLCStatusBase.HasCoil == 1)
            {
                MessageBox.Show("行车有卷状态禁止清除指令");
                return;
            }

            DialogResult ret = MessageBox.Show("确定要清空" + craneNO + "行车的指令吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.Cancel)
                return;

            if (CreateManuOrder.isDelCraneOrder(craneNO))
            {
                MessageBox.Show(craneNO + "指令已清空");
            }
            else
            {
                MessageBox.Show(craneNO + "指令清空失败");
            }


        }

        private void ToolStrip_YardToTard_Click(object sender, EventArgs e)
        {
            FrmYardToYardRequest yard = new FrmYardToYardRequest();
            yard.CraneNo = craneNO;
            yard.Show();
        }
    }
}
