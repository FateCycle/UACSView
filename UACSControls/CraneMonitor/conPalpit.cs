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
using UACSControls;

namespace UACSControls.CraneMonitor
{
    public partial class conPalpit : UserControl
    {

        private Baosight.iSuperframe.Authorization.Interface.IAuthorization auth;
        private Label lbl = new Label();
        private AreaInfo areaInfo = new AreaInfo();
        private AreaBase areaBase = new AreaBase();
        private conPalpit ConPalpit = new conPalpit();
        private AreaRowInfo rowInfo = new AreaRowInfo();
        private static FrmSaddleShow frmSaddleShow = null;
        private bool isCreateLbl = false;
        private string lblRuler;
        public conPalpit()
        {
            InitializeComponent();
            this.Load += conPalpit_Load;
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

        private void conPalpit_Load(object sender, EventArgs e)
        {
            auth = FrameContext.Instance.GetPlugin<IAuthorization>() as IAuthorization;
        }

        public delegate void areaRefreshInvoke(conPalpit theSaddle, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, Panel panel, conPalpit _conArea);

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //public void Control(conPalpit  theSaddle, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, Panel panel, conPalpit _conArea)
        //{
        //    try
        //    {
        //        ConPalpit = theSaddle;

        //        //计算X方向上的比例关系
        //        double xScale = Convert.ToDouble(panelWidth) / Convert.ToDouble(baySpaceX);

        //        double location_X = 0;
        //        if (xAxisRight == true)
        //        {
        //            location_X = Convert.ToDouble(theSaddle.X_Start) * xScale;
        //        }
        //        else
        //        {
        //            location_X = Convert.ToDouble(baySpaceX - (theSaddle.X_End)) * xScale;
        //        }
        //        //计算y方向上的比例关系
        //        double yScale = Convert.ToDouble(panelHeight) / Convert.ToDouble(baySpaceY);

        //        double location_Y = 0;
        //        if (yAxisDown == true)
        //        {
        //            location_Y = Convert.ToDouble(theSaddle.Y_Start) * yScale;
        //        }
        //        else
        //        {
        //            location_Y = Convert.ToDouble(baySpaceY - (theSaddle.Y_End)) * yScale;
        //        }
        //        if (location_Y < 0)
        //        {
        //            location_Y = 0;
        //        }

        //        //定位库区的坐标
        //        this.Location = new Point(Convert.ToInt32(location_X), Convert.ToInt32(location_Y));

        //        //设置鞍座控件的宽度
        //        this.Width = Convert.ToInt32((theSaddle.X_End - theSaddle.X_Start) * xScale);
        //        //设置鞍座控件的高度
        //        this.Height = Convert.ToInt32((theSaddle.Y_End - theSaddle.Y_Start) * yScale);


        //        //当控件的宽小于1时 不显示控件
        //        if (this.Width < 1)
        //        {
        //            this.Visible = false;
        //        }

        //        if (theSaddle.AreaType == 0)
        //        {
        //            if (!isCreateLbl)
        //            {
        //                lbl.Name = theSaddle.AreaNo;
        //                lbl.BackColor = Color.MediumAquamarine;
        //                lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        //                lbl.Width = 95;
        //                lbl.Height = 100;
        //                lbl.ForeColor = Color.Black;
        //                lbl.Click += conPalpit_Click;
        //                _conArea.Controls.Add(lbl);

        //                // List<int> list = rowInfo.getAreaNoRow(areaBase.AreaNo) as List<int>;
        //                // lblRuler = rowInfo.getAreaRowsInfo(list);

        //                isCreateLbl = true;
        //            }

        //            if (panel.Width < 1400)
        //            {
        //                lbl.Width = 60;
        //                lbl.Height = 20;
        //                //lbl.Text = lblRuler;
        //            }
        //            else
        //            {


        //            }
        //            //设置显示的颜色(包括安全门)
        //            //if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 0)
        //            //    this.BackColor = System.Drawing.Color.Red;
        //            //else if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 1)
        //            //    this.BackColor = System.Drawing.Color.Blue;
        //            //else if (theSaddle.AreaDoorSefeValue == 1 && theSaddle.AreaDoorReserveValue == 1)
        //            //    this.BackColor = System.Drawing.Color.Yellow;
        //            //else
        //            this.BackColor = System.Drawing.Color.DarkSeaGreen;



        //            lbl.Location = new Point(this.Width / 2 - 30, this.Height / 2 - 20);
        //            lbl.BackColor = this.BackColor;
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        LogManager.WriteProgramLog(ex.Message);
        //        LogManager.WriteProgramLog(ex.StackTrace);
        //    }
        //}
        //public delegate void EventHandler_Saddle_Selected(conPalpit  theSaddleInfo);
        //public event EventHandler_Saddle_Selected Saddle_Selected;

        //private void conPalpit_Click(object sender, EventArgs e)
        //{
        //    if (frmSaddleShow == null || frmSaddleShow.IsDisposed)
        //    {
        //        frmSaddleShow = new FrmSaddleShow();
        //        frmSaddleShow.AreaBase = areaBase;
        //        frmSaddleShow.Show();
        //    }
        //    else
        //    {
        //        frmSaddleShow.WindowState = FormWindowState.Normal;
        //        frmSaddleShow.Activate();
        //    }
        //}

        //private void conPalpit_Paint(object sender, PaintEventArgs e)
        //{
        //    try
        //    {

        //        Graphics gr = e.Graphics;
        //        Pen p = new Pen(Color.Orange, 2);

        //        if (areaBase.AreaType == 0)
        //        {
        //            gr.DrawString(areaBase.Area_Name,
        //                   new Font("微软雅黑", 14, FontStyle.Bold), Brushes.Blue, new Point(this.Width / 2 - 40, 20));

        //            //        //创建矩形对象                左上角度座标                 宽   高  
        //            Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
        //            gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
        //        }
        //        if (areaBase.AreaType == 1)
        //        {
        //            e.Graphics.DrawString(areaBase.Area_Name, new Font("微软雅黑", 12, FontStyle.Regular),
        //                new SolidBrush(Color.Red), 1, 1, new StringFormat(StringFormatFlags.DirectionVertical));
        //        }


        //    }
        //    catch (Exception er)
        //    {

        //    }
        //}
    }
}
