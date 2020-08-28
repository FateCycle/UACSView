using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baosight.iSuperframe.Forms;
using UACSControls;
using UACSDAL;
using System.Threading;

namespace UACSView.View_CraneMonitor
{
    public partial class _2250_library_Monitor : FormBase
    {

        private List<conCraneStatus> lstConCraneStatusPanel = new List<conCraneStatus>();
        private List<conCrane> listConCraneDisplay = new List<conCrane>();
        private List<string> listCraneNo = new List<string>();


        private conAreaModel areaModel;

        private conUnitSaddleModel unitSaddleModelH145EXIT;
        private conUnitSaddleModel unitSaddleModelH145ENTRY;
        private conUnitSaddleModel unitSaddleModelCH01_WC;
        private conUnitSaddleModel unitSaddleModelCH01_WR;

        private conParkingCarModel parkingCarModel;
        private conOffinePackingSaddleModel offinePacking;
        private CraneStatusInBay craneStatusInBay;

        private bool isShowCurrentBayXY = false;    //是否显示鼠标位置的XY
        private bool tabActived = true;             //是否在当前画面显示

        private string craneNo61 = "61";
        private string craneNo62 = "62";
        private string craneNo63 = "63";

        private const string H145EXIT = "H145-WC";
        private const string H145ENTRY = "H145-WR";
        private const string CH01_WC = "CHAIN_ROW-WC";
        private const string CH01_WR = "CHAIN_ROW-WR";
        public _2250_library_Monitor()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.Load += _2250_library_Monitor_Load;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED 
                return cp;
            }
        }


        void _2250_library_Monitor_Load(object sender, EventArgs e)
        {
            areaModel = new conAreaModel();
            unitSaddleModelH145EXIT = new conUnitSaddleModel();
            unitSaddleModelH145ENTRY = new conUnitSaddleModel();
            unitSaddleModelCH01_WC = new conUnitSaddleModel();
            unitSaddleModelCH01_WR = new conUnitSaddleModel();
            parkingCarModel = new conParkingCarModel();
            offinePacking = new conOffinePackingSaddleModel();


            craneStatusInBay = new CraneStatusInBay();


            //行车显示控件配置
            conCrane61.InitTagDataProvide(constData.tagServiceName);
            conCrane61.CraneNO = craneNo61;
            listConCraneDisplay.Add(conCrane61);

            conCrane62.InitTagDataProvide(constData.tagServiceName);
            conCrane62.CraneNO = craneNo62;
            listConCraneDisplay.Add(conCrane62);

            conCrane63.InitTagDataProvide(constData.tagServiceName);
            conCrane63.CraneNO = craneNo63;
            listConCraneDisplay.Add(conCrane63);


            //---------------------行车状态控件配置-------------------------------
            conCraneStatus61.InitTagDataProvide(constData.tagServiceName);
            conCraneStatus61.CraneNO = craneNo61;
            lstConCraneStatusPanel.Add(conCraneStatus61);

            conCraneStatus62.InitTagDataProvide(constData.tagServiceName);
            conCraneStatus62.CraneNO = craneNo62;
            lstConCraneStatusPanel.Add(conCraneStatus62);

            conCraneStatus63.InitTagDataProvide(constData.tagServiceName);
            conCraneStatus63.CraneNO = craneNo63;
            lstConCraneStatusPanel.Add(conCraneStatus63);

            //---------------------行车tag配置--------------------------------
            craneStatusInBay.InitTagDataProvide(constData.tagServiceName);
            craneStatusInBay.AddCraneNO(craneNo61);
            craneStatusInBay.AddCraneNO(craneNo62);
            craneStatusInBay.AddCraneNO(craneNo63);
            craneStatusInBay.SetReady();


            this.panel2250Bay.Paint += panel2250Bay_Paint;
            //预先加载
            timer_InitializeLoad.Enabled = true;
            timer_InitializeLoad.Interval = 100;
        }

        void panel2250Bay_Paint(object sender, PaintEventArgs e)
        {
            #region 引用对象
            Graphics gr = e.Graphics;
            #endregion


            Pen p1 = new Pen(Color.White, 1);

            #region 比例换算
            //计算X方向上的比例关系
            //double xScale = Convert.ToDouble(panel2250Bay.Width) / Convert.ToDouble(constData.Z2250BaySpaceX);
            //计算Y方向的比例关系
            //double yScale = Convert.ToDouble(panel2250Bay.Height) / Convert.ToDouble(constData.Z2250BaySpaceY);
            #endregion


        }

        private void LoadAreaInfo()
        {
            areaModel.conInit(panel2250Bay,
                constData.bayNo,
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown,
                 AreaInfo.AreaType.AllType);
        }

        private void  LoadOffinePackSaddle()
        {
            offinePacking.conInit(panel2250Bay,
                "EY5",
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown);

        }

        private void LoadUnitInfo()
        {
            unitSaddleModelH145EXIT.conInit(panel2250Bay,
                H145EXIT,
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown,
                constData.bayNo);

            unitSaddleModelH145ENTRY.conInit(panel2250Bay,
                H145ENTRY,
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown,
                constData.bayNo);

            unitSaddleModelCH01_WC.conInit(panel2250Bay,
               CH01_WC,
               constData.tagServiceName,
               constData.Z2250BaySpaceX,
               constData.Z2250BaySpaceY,
               constData.xAxisRight,
               constData.yAxisDown,
               constData.bayNo);
            unitSaddleModelCH01_WR.conInit(panel2250Bay,
               CH01_WR,
               constData.tagServiceName,
               constData.Z2250BaySpaceX,
               constData.Z2250BaySpaceY,
               constData.xAxisRight,
               constData.yAxisDown,
               constData.bayNo);
        }

        private void LoadPacking()
        {
            parkingCarModel.conInit(panel2250Bay,
                "TRE",
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown);
        }


        private void timer_InitializeLoad_Tick(object sender, EventArgs e)
        {

            LoadOffinePackSaddle();

            LoadUnitInfo();

            LoadPacking();

            LoadAreaInfo();

            Thread.Sleep(500);


            timerCrane.Enabled = true;
            timerArea.Enabled = true;
            timerUnit.Enabled = true;


            timerCrane.Interval = 1500;
            timerArea.Interval = 10000;
            timerUnit.Interval = 10000;

            timer_InitializeLoad.Enabled = false;
        }

        private void timerCrane_Tick(object sender, EventArgs e)
        {
            if (tabActived == false)
            {
                return;
            }

            craneStatusInBay.getAllPLCStatusInBay(craneStatusInBay.lstCraneNO);

            if (this.Height < 10)
            {
                return;
            }

            try
            {
                //--------------------------行车指令控件刷新------------------------------------------
                foreach (conCraneStatus conCraneStatusPanel in lstConCraneStatusPanel)
                {
                    conCraneStatus.RefreshControlInvoke ConCraneStatusPanel_Invoke = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl);
                    conCraneStatusPanel.BeginInvoke(ConCraneStatusPanel_Invoke, new Object[] { craneStatusInBay.DicCranePLCStatusBase[conCraneStatusPanel.CraneNO].Clone() });
                }
                //--------------------------行车状态控件刷新-------------------------------------------
                foreach (conCrane conCraneVisual in listConCraneDisplay)
                {
                    conCrane.RefreshControlInvoke ConCraneVisual_Invoke = new conCrane.RefreshControlInvoke(conCraneVisual.RefreshControl);
                    conCraneVisual.BeginInvoke(ConCraneVisual_Invoke, new Object[] 
                    { craneStatusInBay.DicCranePLCStatusBase[conCraneVisual.CraneNO].Clone(), 
                         constData.Z2250BaySpaceX,
                         constData.Z2250BaySpaceY,
                         panel2250Bay.Width,
                         panel2250Bay.Height,
                         constData.xAxisRight,
                         constData.yAxisDown,
                         8000,         
                         panel2250Bay 
                    });
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("{0},{1}", er.Message, er.Source));
                timerCrane.Enabled = false;
            }
        }

        private void timerArea_Tick(object sender, EventArgs e)
        {
            if (tabActived == false)
            {
                return;
            }

            if (this.Height < 10)
            {
                return;
            }
           

            LoadAreaInfo();
        }

        private void btnShowCrane_Click(object sender, EventArgs e)
        {
            if (btnShowCrane.Text == "隐藏行车")
            {
                conCrane61.Visible = false;
                conCrane62.Visible = false;
                conCrane63.Visible = false;
                btnShowCrane.Text = "显示行车";
            }
            else
            {
                conCrane61.Visible = true;
                conCrane62.Visible = true;
                conCrane63.Visible = true;
                btnShowCrane.Text = "隐藏行车";
            }
        }

        private void timerUnit_Tick(object sender, EventArgs e)
        {
            if (tabActived == false)
            {
                return;
            }
            if (this.Height < 10)
            {
                return;
            }
            LoadPacking();
            LoadOffinePackSaddle();
            LoadUnitInfo();
        }

        private void btnShowXY_Click(object sender, EventArgs e)
        {
            if (!isShowCurrentBayXY)
            {
                isShowCurrentBayXY = true;
                btnShowXY.Text = "取消显示";

                timer_ShowXY.Enabled = true;
                timer_ShowXY.Interval = 1000;
            }
            else
            {
                isShowCurrentBayXY = false;
                btnShowXY.Text = "显示XY";
                timer_ShowXY.Enabled = false;

            }
        }

        private void timer_ShowXY_Tick(object sender, EventArgs e)
        {
            if (tabActived == false)
            {
                return;
            }

            if (this.Height < 10)
            {
                return;
            }
            
            if (isShowCurrentBayXY)
            {
                //计算X方向上的比例关系
                double xScale = Convert.ToDouble(panel2250Bay.Width) / Convert.ToDouble(constData.Z2250BaySpaceX);
                //计算Y方向的比例关系
                double yScale = Convert.ToDouble(panel2250Bay.Height) / Convert.ToDouble(constData.Z2250BaySpaceY);

                Point p = this.panel2250Bay.PointToClient(Control.MousePosition);
                if (p.X <= this.panel2250Bay.Location.X || p.X >= this.panel2250Bay.Location.X + this.panel2250Bay.Width ||
                    p.Y < this.panel2250Bay.Location.Y || p.Y >= this.panel2250Bay.Location.Y + this.panel2250Bay.Height)
                {
                    return;
                }
                txtX.Text = Convert.ToString(Convert.ToInt32(Convert.ToDouble(panel2250Bay .Width - p.X) / xScale));
                txtY.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(panel2250Bay.Height) - Convert.ToDouble(p.Y)) / yScale));
            }
        }


        void MyTabActivated(object sender, EventArgs e)
        {
            tabActived = true;
        }
        void MyTabDeactivated(object sender, EventArgs e)
        {
            tabActived = false;
        }

       
    }
}
