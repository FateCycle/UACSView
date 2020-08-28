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
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using System.Reflection;
using UACSDAL.CraneMonitor;
using Baosight.iSuperframe.TagService;
using System.Net;
using UACSControls.CraneMonitor;
using UACSDAL.Common;
using antlr;

namespace UACSView.View_CraneMonitor
{
    public partial class _Form_library_Monitor : FormBase
    {
        IAuthorization auth = Baosight.iSuperframe.Common.FrameContext.Instance.GetPlugin<Baosight.iSuperframe.Authorization.Interface.IAuthorization>()
  as Baosight.iSuperframe.Authorization.Interface.IAuthorization;

        #region iPlature配置
        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDP = null;
        public Baosight.iSuperframe.TagService.Controls.TagDataProvider TagDP
        {
            get
            {
                if (tagDP == null)
                {
                    try
                    {
                        tagDP = new Baosight.iSuperframe.TagService.Controls.TagDataProvider();
                        tagDP.ServiceName = "iplature";
                        tagDP.AutoRegist = true;
                    }
                    catch (System.Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                return tagDP;
            }
            //set { tagDP = value; }
        }
        #endregion

        #region 数据库连接
        private static Baosight.iSuperframe.Common.IDBHelper dbHelper = null;
        //连接数据库
        private static Baosight.iSuperframe.Common.IDBHelper DBHelper
        {
            get
            {
                if (dbHelper == null)
                {
                    try
                    {
                        dbHelper = Baosight.iSuperframe.Common.DataBase.DBFactory.GetHelper("localAPP");//平台连接数据库的Text
                    }
                    catch (System.Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                return dbHelper;
            }
        }
        #endregion
        //datagridview1
        DataTable dt = new DataTable();
        DataTable dt_selected = new DataTable();
        DataTable dtByParkScanInfo = new DataTable();
        DataTable dtByUnitScanInfo = new DataTable();
        DataTable dtByL3Order = new DataTable();
        DataTable dt_table = new DataTable();
        DataTable dt_tb = new DataTable();
        DataTable dt_tbb = new DataTable();
        DataTable dt_tabb = new DataTable();
        DataTable dtNull = new DataTable();
        ToolTip toolTip1 = new ToolTip();


        private List<conCraneStatus> lstConCraneStatusPanel = new List<conCraneStatus>();
        private List<conCrane> listConCraneDisplay = new List<conCrane>();
        private List<string> listCraneNo = new List<string>();
        private List<UserMessage> lstConCraneStatusPanel01 = new List<UserMessage>();
        private List<UserMessageShow> lstConCraneStatusPanel02 = new List<UserMessageShow>();
        private conAreaModel areaModel;
        //private List<TLineSlabInfo> lstLineSlabInfos = new List<TLineSlabInfo>();
        private List<TLineSlabInfo> lstLineSlabInfod = new List<TLineSlabInfo>();
        private List<ManualInfo> ManualInfos = new List<ManualInfo>();
        private conUnitSaddleModel unitSaddleModelEXIT;
        //private conUnitSaddleModel unitSaddleModelH145ENTRY;
        //private conUnitSaddleModel unitSaddleModelCH01_WC;
        //private conUnitSaddleModel unitSaddleModelCH01_WR;

        private conParkingCarModel parkingCarModel;
        private conOffinePackingSaddleModel offinePacking;
        private CraneStatusInBay craneStatusInBay;

        //private OrderDownLocationControl orderDownLocationControl = new OrderDownLocationControl();

        private Label lblPoint = new Label();
        private Label lblPointInfo = new Label();

        //  private AreaInfo areaInfo;
        public string CMD_STATUSD;//

        private bool isShowCurrentBayXY = false;    //是否显示鼠标位置的XY
        private bool tabActived = true;             //是否在当前画面显示

        private string craneNo86 = "6";
       //  private string craneNo62 = "62";
      //  private string craneNo63 = "63";

        private const string UNIT_EXIT = "UNIT_EXIT";
        private const string H145ENTRY = "H145-WR";
        private const string CH01_WC = "CHAIN_ROW-WC";
        private const string CH01_WR = "CHAIN_ROW-WR";

        private string tagValue = String.Empty;
 
        private string[] arrTagAdress = new string[] { "LINE_EXIT_LOCK_STATUS" };
        private string[] arrTagAdressd = new string[] { "LINE_EXIT_ACTION_STATUS" };
        private DataCollection<object> inDatas = new  DataCollection<object>();
        private DataCollection<object> inData = new DataCollection<object>();
        string _sqlCmdSelectParkingStatus = "SELECT PARKING_NO, TREATMENT_NO, CAR_NO, ISLOADED, LASER_ACTION_COUNT, PARKING_STATUS FROM UACS_PARKING_STATUS WHERE PARKING_NO = 'CC1TV01'";
        string _sqlCmdSelectParkingLaser = "SELECT  PARKING_NO, TREATMENT_NO, GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID, LASER_ACTION_COUNT FROM UACS_LASER_OUT WHERE TREATMENT_NO = (SELECT TREATMENT_NO FROM UACS_PARKING_STATUS WHERE PARKING_NO = 'CC1TV01')";
        string _sqlCmdSelectManualOrder = "SELECT  T.*,T1.X FROM_STOCK_X,T1.Y FROM_STOCK_Y,T1.Z FROM_STOCK_Z,T1.LAYER_NO,T2.X TO_STOCK_X,T2.Y TO_STOCK_Y,T2.Z TO_STOCK_Z,T2.LAYER_NO FROM UACS_CRANE_MANU_ORDER T LEFT JOIN UACS_YARDMAP_TRAIN_STOCK_DEFINE T1 ON T.FROM_STOCK_NO = T1.STOCK_NO LEFT JOIN UACS_YARDMAP_TRAIN_STOCK_DEFINE T2 ON T.TO_STOCK_NO = T2.STOCK_NO WHERE T.CRANE_NO = '86'";
        string _sqlCmdSelectCurrentOrder = "SELECT * FROM UACS_CRANE_ORDER_CURRENT WHERE CRANE_NO = '86'";
        string _sqlCmdSelectL3Order = "select * from UACS_CRANE_ORDER_L3 order by REC_TIME desc fetch first 20 rows only";
        // string _sqlCmdSelectLineUnitInfo = "SELECT * FROM UACS_LINE_EXIT_INFO"; 
        string _sqlCmdSelectLineUnitInfo = "SELECT A.STOCK_NO,A.MAT_NO_1,A.MAT_NO_2,B.X,B.Y,B.Z FROM UACS_LINE_EXIT_INFO A left join UACS_YARDMAP_TRAIN_STOCK_DEFINE B ON A.STOCK_NO=B.STOCK_NO";
         string _sqlCmdSelectUnitLaser = "SELECT T.TREATMENT_NO,T1.XMAX, T1.XMIN, T1.YMAX, T1.YMIN, T1.INDEX_Y, T1.X_CENTER, T1.Y_CENTER FROM UACS_LASER_LINE_EXIT_STATUS T LEFT JOIN UACS_LASER_LINE_EXIT_INFO T1 ON T.TREATMENT_NO = T1.TREATMENT_NO WHERE T.ENABLE_FLAG ='1'";
        string _sqlCmdSelecttrainParking = "select a.PARK_POS,a.LOAD_FLAG,b.STOCK_STATUS from UACS_PARKING_TRAIN_LOAD_INFO a left join UACS_YARDMAP_TRAIN_STOCK_DEFINE b on a.STOCK_NO=b.STOCK_NO";
        string _sqlCmdSelectManualInfo = " SELECT * FROM UACS_LINE_EXIT_MANUAL";
        string _sqlCmdSelectCMDSTATUS = "SELECT CMD_STATUS FROM UACS_CRANE_MANU_ORDER where CRANE_NO='86'";
        public _Form_library_Monitor()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.Load += _Form_library_Monitor_Load;
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


        void _Form_library_Monitor_Load(object sender, EventArgs e)
        {
            areaModel = new conAreaModel();
            unitSaddleModelEXIT = new conUnitSaddleModel();
            //unitSaddleModelH145ENTRY = new conUnitSaddleModel();
            //unitSaddleModelCH01_WC = new conUnitSaddleModel();
            //unitSaddleModelCH01_WR = new conUnitSaddleModel();
          //  unitSaddleModelMC1 = new conUnitSaddleModel();
            parkingCarModel = new conParkingCarModel();

            offinePacking = new conOffinePackingSaddleModel();


            craneStatusInBay = new CraneStatusInBay();
           //areaInfo = new AreaInfo();
            

            //行车显示控件配置
            //conCrane86.InitTagDataProvide(constData.tagServiceName);
            conCrane86.CraneNO = craneNo86;
            listConCraneDisplay.Add(conCrane86);

            lblPoint = conCrane86.LBL_POINT;
            lblPoint.Size = new Size(10, 10);
            lblPoint.BackColor = Color.Red;
            panelBay.Controls.Add(lblPoint);
            lblPoint.Visible = false;

            lblPointInfo = conCrane86.LBL_POINTINFO;
            lblPointInfo.Size = new Size(60, 50);
            lblPointInfo.Font = new Font("微软雅黑", 7, FontStyle.Bold);
            lblPointInfo.BackColor = SystemColors.Info;
            panelBay.Controls.Add(lblPointInfo);
            lblPointInfo.Visible = false;



        //    conCrane62.InitTagDataProvide(constData.tagServiceName);
         //   conCrane62.CraneNO = craneNo62;
         //   listConCraneDisplay.Add(conCrane62);

          //  conCrane63.InitTagDataProvide(constData.tagServiceName);
          //  conCrane63.CraneNO = craneNo63;
          //  listConCraneDisplay.Add(conCrane63);


            //---------------------行车状态控件配置-------------------------------
            conCraneStatus86.InitTagDataProvide(constData.tagServiceName);
            conCraneStatus86.CraneNO = craneNo86;
            lstConCraneStatusPanel.Add(conCraneStatus86);

            //机组库位
            //TLineSlabInfo p1 = new TLineSlabInfo();
            //p1.STOCK_NO = "P1";
            //TLineSlabInfo p2 = new TLineSlabInfo();
            //p2.STOCK_NO = "P2";
            //TLineSlabInfo p3 = new TLineSlabInfo();
            //p3.STOCK_NO = "P3";
            //TLineSlabInfo p4 = new TLineSlabInfo();
            //p4.STOCK_NO = "P4";
            //TLineSlabInfo p5 = new TLineSlabInfo();
            //p5.STOCK_NO = "P5";
            //lstLineSlabInfos.Add(p1);
            //lstLineSlabInfos.Add(p2);
            //lstLineSlabInfos.Add(p3);
            //lstLineSlabInfos.Add(p4);
            //lstLineSlabInfos.Add(p5);
            TLineSlabInfo m1 = new TLineSlabInfo();
            m1.PARK_POS = "1#";
            TLineSlabInfo m2 = new TLineSlabInfo();
            m2.PARK_POS = "2#";
            TLineSlabInfo m3 = new TLineSlabInfo();
            m3.PARK_POS = "3#";
            lstLineSlabInfod.Add(m1);
            lstLineSlabInfod.Add(m2);
            lstLineSlabInfod.Add(m3);

            ManualInfo POS1 = new ManualInfo();
            POS1.STOCK_NO = "POS1";
            ManualInfo POS2 = new ManualInfo();
            POS2.STOCK_NO = "POS2";
            ManualInfo POS3 = new ManualInfo();
            POS3.STOCK_NO = "POS3";
            ManualInfo POS4 = new ManualInfo();
            POS4.STOCK_NO = "POS4";
            ManualInfo POS5 = new ManualInfo();
            POS5.STOCK_NO = "POS5";
            ManualInfos.Add(POS1);
            ManualInfos.Add(POS2);
            ManualInfos.Add(POS3);
            ManualInfos.Add(POS4);
            ManualInfos.Add(POS5);
            userMessage1.InitTagDataProvide(constData.tagServiceName);
            userMessage1.CraneNO = craneNo86;
            lstConCraneStatusPanel01.Add(userMessage1);

            //panelBay.Controls.Add(orderDownLocationControl);
            //orderDownLocationControl.Location = orderPoint;
            //orderDownLocationControl.Visible = true;
            //orderDownLocationControl.Parent = panelBay;
  


            //userMessageShow1.InitTagDataProvide(constData.tagServiceName);
            //userMessageShow1.CraneNO = craneNo86;
            //lstConCraneStatusPanel02.Add(userMessageShow1);
            //  conCraneStatus62.InitTagDataProvide(constData.tagServiceName);
            //    conCraneStatus62.CraneNO = craneNo62;
            //    lstConCraneStatusPanel.Add(conCraneStatus62);

            //   conCraneStatus63.InitTagDataProvide(constData.tagServiceName);
            //  conCraneStatus63.CraneNO = craneNo63;
            //  lstConCraneStatusPanel.Add(conCraneStatus63);

            //---------------------行车tag配置--------------------------------
            craneStatusInBay.InitTagDataProvide(constData.tagServiceName);
            craneStatusInBay.AddCraneNO(craneNo86);
          //  craneStatusInBay.AddCraneNO(craneNo62);
          //  craneStatusInBay.AddCraneNO(craneNo63);
            craneStatusInBay.SetReady();
         //   areaInfo.getTagNameList();

            InitDataGridView(dgvByParking);
            //InitDataGridView(dgvByL3Order);
            InitDataGridView(dgvByUnitScan);

                
            this.panelBay.Paint += panel2250Bay_Paint;
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
        private void InitDataGridView(DataGridView dt)
        {
            dt.AllowUserToAddRows = false;
            dt.AllowUserToOrderColumns = false;
            dt.EnableHeadersVisualStyles = false;
            dt.AutoGenerateColumns = false;
            dt.RowHeadersVisible = false;
            dt.ReadOnly = true;
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            //dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dt.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.BackgroundColor = SystemColors.Info;
            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dt.RowHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dt.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dt.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10F );
            dt.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10F);
            //dt.Columns.Add("SADDLE_L2NAME", "鞍座序号");
            //dt.Columns.Add("STOCK_NO", "鞍座号");
            //dt.Columns.Add("COIL_NO", "材料号");
            //dt.Columns.Add("WEIGHT", "重量");
            //dt.Columns.Add("WIDTH", "宽度");
            //dt.Columns.Add("INDIA", "内径");
            //dt.Columns.Add("OUTDIA", "外径");
            //dt.Columns.Add("COIL_OPEN_DIRECTION", "开卷方向");
            //dt.Columns.Add("COIL_STATUS", "状态");

            //dt.Columns[0].DataPropertyName = "SADDLE_L2NAME";
            //dt.Columns[1].DataPropertyName = "STOCK_NO";
            //dt.Columns[2].DataPropertyName = "COIL_NO";
            //dt.Columns[3].DataPropertyName = "WEIGHT";
            //dt.Columns[4].DataPropertyName = "WIDTH";
            //dt.Columns[5].DataPropertyName = "INDIA";
            //dt.Columns[6].DataPropertyName = "OUTDIA";
            //dt.Columns[7].DataPropertyName = "COIL_OPEN_DIRECTION";
            //dt.Columns[7].DataPropertyName = "COIL_STATUS";
            //dgv.Columns[0].Width = 120;
            //dgv.Columns[_colStockNo].Width = 120;
            //for (int i = 1; i < dgv.Columns.Count; i++)
            //{
            //    if (i == _colStockNo)
            //    {
            //        continue;
            //    }
            //    dgv.Columns[i].Width = (dgv.Width - dgv.RowHeadersWidth - 240) / (dgv.Columns.Count);
            //}

            //dgv.Columns[_colByWeight].ReadOnly = true;
            //dgv.Columns[_colByWidth].ReadOnly = true;
            //dgv.Columns[_colByIndia].ReadOnly = true;
            //dgv.Columns[_colByOutdia].ReadOnly = true;
            //dgv.Columns[_colStockNo].ReadOnly = true;
            
            dt.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dt, true, null);


        }
        //库区
        private void LoadAreaInfo()
        {
            // 获取库区
            areaModel.conInit(panelBay,
                constData.bayNo,
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown,
                 AreaInfo.AreaType.AllType);
         
        }
        public void LoadPalpitInfo()
        {
            areaModel.conPalpit(panelBay,
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
            offinePacking.conInit(panelBay,
                "EY5",
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown);

        }
        //方坯
        private void LoadUnitInfo()
        {
            //
            unitSaddleModelEXIT.conInit(panelBay,
                UNIT_EXIT,
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown,
                constData.bayNo);

            //unitSaddleModelH145ENTRY.conInit(panel2250Bay,
            //    H145ENTRY,
            //    constData.tagServiceName,
            //    constData.Z2250BaySpaceX,
            //    constData.Z2250BaySpaceY,
            //    constData.xAxisRight,
            //    constData.yAxisDown,
            //    constData.bayNo);

            //unitSaddleModelCH01_WC.conInit(panel2250Bay,
            //   CH01_WC,
            //   constData.tagServiceName,
            //   constData.Z2250BaySpaceX,
            //   constData.Z2250BaySpaceY,
            //   constData.xAxisRight,
            //   constData.yAxisDown,
            //   constData.bayNo);

            //unitSaddleModelCH01_WR.conInit(panel2250Bay,
            //   CH01_WR,
            //   constData.tagServiceName,
            //   constData.Z2250BaySpaceX,
            //   constData.Z2250BaySpaceY,
            //   constData.xAxisRight,
            //   constData.yAxisDown,
            //   constData.bayNo);
        }
        //火车
        private void LoadPacking()
        {
            //TRE
            parkingCarModel.conInit(panelBay,
                "Z33A1",
                constData.tagServiceName,
                constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY,
                constData.xAxisRight,
                constData.yAxisDown);
        }


        private void timer_InitializeLoad_Tick(object sender, EventArgs e)
        {

          //  LoadOffinePackSaddle();
          //  //LoadPalpitInfo();
          //  LoadUnitInfo();

          //LoadPacking();

          // LoadAreaInfo();

            Thread.Sleep(500);



            //timerCrane.Enabled = true;
            timerArea.Enabled = true;
            timerAreaAndSaddle.Enabled = true;
            timer_ParkScanInfo.Enabled = true;

            timerCrane.Interval = 1500;
            timerArea.Interval = 3000;
            timerAreaAndSaddle.Interval = 5000;
            timerCrane.Enabled = true;
            timer_RefreshUnit.Enabled = true;
            timer_RefreshOrder.Enabled = true;
            timer_InitializeLoad.Enabled = true;
            timer_TrainParking.Enabled = true;
            craneStatusInBay.getAllPLCStatusInBay(craneStatusInBay.lstCraneNO);

            //areaInfo.getTagValues();
            

            // 行车未知的刷新
            foreach (conCrane conCraneVisual in listConCraneDisplay)
            {
                conCrane.RefreshControlInvoke ConCraneVisual_Invoke = new conCrane.RefreshControlInvoke(conCraneVisual.RefreshControl);
                conCraneVisual.BeginInvoke(ConCraneVisual_Invoke, new Object[]
                            { craneStatusInBay.DicCranePLCStatusBase[conCraneVisual.CraneNO].Clone(),
                                 constData.Z2250BaySpaceX,
                                 constData.Z2250BaySpaceY,
                                 panelBay.Width,
                                 panelBay.Height,
                                 constData.xAxisRight,
                                 constData.yAxisDown,
                                 //修改行车的宽度
                                 4000,
                                 panelBay
            });
                inDatas.Clear();
                TagDP.GetData(new string[]{ craneNo86 + "_ALARM_CURRENT"},out inDatas);
                conCraneVisual.toggle(inDatas[craneNo86 + "_ALARM_CURRENT"].ToString());            
            }



            //  行车状态的刷新
            foreach (conCraneStatus conCraneStatusPanel in lstConCraneStatusPanel)
            {
                conCraneStatus.RefreshControlInvoke ConCraneStatusPanel_Invoke = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl);
                conCraneStatusPanel.BeginInvoke(ConCraneStatusPanel_Invoke, new Object[] { craneStatusInBay.DicCranePLCStatusBase[conCraneStatusPanel.CraneNO].Clone() });
                inDatas.Clear();
                TagDP.GetData(new string[] { craneNo86 + "_ALARM_CURRENT" }, out inDatas);
                conCraneStatusPanel.toggle(inDatas[craneNo86 + "_ALARM_CURRENT"].ToString());

            }


            


        }

        //private void timerCrane_Tick(object sender, EventArgs e)
        //{
        //  //STER();
        //    if (tabActived == false)
        //    {
        //        return;
        //    }
        //    // LoadAreaInfo();
        //    craneStatusInBay.getAllPLCStatusInBay(craneStatusInBay.lstCraneNO);

        // //   areaInfo.getTagValues();
        //    if (this.Height < 10)
        //    {
        //        return;
        //    }
        //    //try
        //    //{
        //    //new add
        //    //计算X方向上的比例关系
        //    double xScale = Convert.ToDouble(panelBay.Width) / Convert.ToDouble(constData.Z2250BaySpaceX);
        //    //计算Y方向的比例关系
        //    double yScale = Convert.ToDouble(panelBay.Height) / Convert.ToDouble(constData.Z2250BaySpaceY);

        //    foreach (UserMessage conCraneStatusPanel in lstConCraneStatusPanel01)
        //    {

        //        conCraneStatus.RefreshControlInvoke ConCraneStatusPanel_Invoke01 = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl01);
        //        //    conCraneStatus.RefreshControlInvoke con = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl);


        //        conCraneStatusPanel.BeginInvoke(ConCraneStatusPanel_Invoke01, new Object[] { craneStatusInBay.DicCranePLCStatusBase[conCraneStatusPanel.CraneNO].Clone() });
        //    }

        //    //foreach (UserMessageShow conCraneStatusPanel in lstConCraneStatusPanel02)
        //    //{

        //    //    conCraneStatus.RefreshControlInvoke ConCraneStatusPanel_Invoke02 = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl02);
        //    //    //    conCraneStatus.RefreshControlInvoke con = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl);


        //    //    conCraneStatusPanel.BeginInvoke(ConCraneStatusPanel_Invoke02, new Object[] { craneStatusInBay.DicCranePLCStatusBase[conCraneStatusPanel.CraneNO].Clone() });
        //    //}
        //    //--------------------------行车状态控件刷新-------------------------------------------

        //        foreach (conCrane conCraneVisual in listConCraneDisplay)
        //            {
        //                conCrane.RefreshControlInvoke ConCraneVisual_Invoke = new conCrane.RefreshControlInvoke(conCraneVisual.RefreshControl);
        //    conCraneVisual.BeginInvoke(ConCraneVisual_Invoke, new Object[]
        //                { craneStatusInBay.DicCranePLCStatusBase[conCraneVisual.CraneNO].Clone(),
        //                     constData.Z2250BaySpaceX,
        //                     constData.Z2250BaySpaceY,
        //                     panelBay.Width,
        //                     panelBay.Height,
        //                     constData.xAxisRight,
        //                     constData.yAxisDown,
        //                     //修改行车的宽度
        //                     4000,
        //                     panelBay
        //});
        //        }

        //    //--------------------------行车指令控件刷新------------------------------------------
        //    foreach (conCraneStatus conCraneStatusPanel in lstConCraneStatusPanel)
        //    {
        //        conCraneStatus.RefreshControlInvoke ConCraneStatusPanel_Invoke = new conCraneStatus.RefreshControlInvoke(conCraneStatusPanel.RefreshControl);
        //        conCraneStatusPanel.BeginInvoke(ConCraneStatusPanel_Invoke, new Object[] { craneStatusInBay.DicCranePLCStatusBase[conCraneStatusPanel.CraneNO].Clone() });
        //    }
        //    //}
        //    //catch (Exception er)
        //    //{
        //    //    MessageBox.Show(string.Format("{0},{1}", er.Message, er.Source));
        //    //    timerCrane.Enabled = false;
        //    //}
        //}
        #region
        public void InsertRecord(string TextValue)
        {
            //获取当前时间
            string MeText = TextValue;
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string HostName = Dns.GetHostName();
            //  Console.WriteLine("主机名是：" + HostName);
            //遍历地址列表，如果电脑有多网卡只能这样遍历显示
            IPAddress[] iplist = Dns.GetHostAddresses(HostName);
            for (int i = 0; i < iplist.Length; i++)
            {
                string mIp = iplist[i].ToString();
                // Console.WriteLine("IP地址：" + iplist[i]);
                string MIPVALUE = mIp.Substring(0, 3);
                if (MIPVALUE == "192")
                {
                    try
                    {
                        string sql = @"insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('" + mIp + "','" + MeText + "','" + date + "')";
                        //  string sqlm = @"update UACS_HMI_OPER_HISTORY SET REC_TIME=current timestamp where HOST_IP='" + mIp + "'";
                        DB2Connect.DBHelper.ExecuteNonQuery(sql);
                        //  DB2Connect.DBHelper.ExecuteNonQuery(sqlm);
                    }
                    catch (Exception er)
                    {

                    }
                }
            }
        }

        #endregion
        #region 
        public void STER()
        {
            //dataGridView4.AutoGenerateColumns = false;
            //dataGridView2.AutoGenerateColumns = false;
            //dataGridView3.AutoGenerateColumns = false;
            dtByParkScanInfo.Clear();
            dt_table.Clear();
            dt_tb.Clear();
            dt_tabb.Clear();
            //txt_ENABLE_FLAG.Text = "";
            //txt_NAME.Text = "";
            //txt_TREATMENT_NO.Text = "";
            //textBox1.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox6.Text = "";
            //textBox8.Text = "";
            //  txt_MAT_NO_1.Text = "";
            //try
            //{
                string sqlText = "SELECT * FROM UACS_LASER_LINE_EXIT_INFO A LEFT JOIN UACS_LASER_LINE_EXIT_STATUS B ON A.TREATMENT_NO=B.TREATMENT_NO where 1=1 ";


                //if (dataGridView4.DataSource != null)
                //{
                //    dt_Laser.Clear();
                //}
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    dtByParkScanInfo.Load(rdr);


                }
            //dataGridView4.DataSource = dt_Laser;


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
            //try
            //{
            //    string sqlText1 = "select * from UACS_CRANE_ORDER_L3 order by REC_TIME desc fetch first 1 rows only ";


            //    if (dataGridView2.DataSource != null)
            //    {
            //        dt_table.Clear();
            //    }
            //    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText1))
            //    {
            //        dt_table.Load(rdr);

            //        foreach (DataRow item in dt_table.Rows)
            //        {
            //            textBox1.Text = ManagerHelper.JudgeStrNull(item["ORDER_TYPE"]);
            //            textBox4.Text = ManagerHelper.JudgeStrNull(item["MAT_NO_1"]);
            //            textBox3.Text = ManagerHelper.JudgeStrNull(item["MAT_NO_2"]);
            //            textBox6.Text = ManagerHelper.JudgeStrNull(item["TO_STOCK_NO"]);
            //            textBox8.Text = ManagerHelper.JudgeStrNull(item["FROM_STOCK_NO"]);
            //        }


            //    }
            //    dataGridView2.DataSource = dt_table;


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
            //try
            //{


            //额外的注释
            // *****
            //string sqlText1 = "select * from UACS_CRANE_ORDER_L3 where cast(REC_TIME as varchar(30))!='null' order by REC_TIME desc fetch first 5 rows only ";


            //if (dgvByL3Order.DataSource != null)
            //{
            //    dt_tabb.Clear();
            //}
            //using (IDataReader rdr = DBHelper.ExecuteReader(sqlText1))
            //{
            //    dt_tabb.Load(rdr);


            //}
            //dgvByL3Order.DataSource = dt_tabb;


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
            //try
            //{
            string sqlText2 = "select STOCK_NO AS STOCK_NO, MAT_NO_1 AS MAT_NO1, MAT_NO_2 AS MAT_NO2,MAT_GROUP_NO AS MAT_GROUP_NO from UACS_LINE_EXIT_INFO where 1=1 ";


                //if (dataGridView3.DataSource != null)
                //{
                //    dt_tb.Clear();
                //}
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText2))
                {
                    dt_tb.Load(rdr);
                    foreach (DataRow item in dt_tb.Rows)
                    {
                        string nn = ManagerHelper.JudgeStrNull(item["STOCK_NO"]);
                        if (nn == "" || nn == null)
                        {
                            //   txt_MAT_NO_1.Text = "6666";

                        }
                        else
                        {
                            //  txt_MAT_NO_1.Text = nn;

                        }
                    }

                }
                //dataGridView3.DataSource = dt_tb;


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}
            //try
            //{
            //    string sqlText3 = "SELECT * FROM UACS_LASER_LINE_EXIT_STATUS WHERE 1=1 ";
            //    using (IDataReader rdr3 = DBHelper.ExecuteReader(sqlText3))
            //    {
            //        dt_tbb.Load(rdr3);
            //        foreach (DataRow item in dt_tbb.Rows)
            //        {
            //            txt_NAME.Text = ManagerHelper.JudgeStrNull(item["NAME"]);
            //            txt_TREATMENT_NO.Text = ManagerHelper.JudgeStrNull(item["TREATMENT_NO"]);
            //            txt_ENABLE_FLAG.Text = ManagerHelper.JudgeStrNull(item["ENABLE_FLAG"]);

            //        }
            //    }


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}

            //车到，车离，激光扫描
        }
        #endregion
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
          //  LoadUnitInfo();
            //LoadPacking();
            //LoadAreaInfo();
        }
        private void btnShowCrane_Click(object sender, EventArgs e)
        {
            if (btnShowCrane.Text == "隐藏行车")
            {
                conCrane86.Visible = false;
             //   conCrane62.Visible = false;
             //   conCrane63.Visible = false;
                btnShowCrane.Text = "显示行车";
            }
            else
            {
                conCrane86.Visible = true;
             //   conCrane62.Visible = true;
             //   conCrane63.Visible = true;
                btnShowCrane.Text = "隐藏行车";
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
            /// LoadPacking();
            //  LoadOffinePackSaddle();     
           LoadAreaInfo();
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
                double xScale = Convert.ToDouble(panelBay.Width) / Convert.ToDouble(constData.Z2250BaySpaceX);
                //计算Y方向的比例关系
                double yScale = Convert.ToDouble(panelBay.Height) / Convert.ToDouble(constData.Z2250BaySpaceY);

                Point p = this.panelBay.PointToClient(Control.MousePosition);
                if (p.X <= this.panelBay.Location.X || p.X >= this.panelBay.Location.X + this.panelBay.Width ||
                    p.Y < this.panelBay.Location.Y || p.Y >= this.panelBay.Location.Y + this.panelBay.Height)
                {
                    return;
                }
                txtX.Text = Convert.ToString(Convert.ToInt32(Convert.ToDouble(panelBay .Width - p.X) / xScale));
                txtY.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(panelBay.Height) - Convert.ToDouble(p.Y)) / yScale));
            }
        }

        private void panel2250Bay_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timerClear_Tick(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("111");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conCrane86_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2250Bay_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void timer_ParkScanInfo_Tick(object sender, EventArgs e)
        {
            try
            {

                if (tabActived == false)
                {

                    return;
                }
                if (this.Height < 10)
                {
                    return;
                }
                dtByParkScanInfo.Clear();
                using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectParkingLaser))
                {         
                    dtByParkScanInfo.Load(rdr);
                    dgvByParking.DataSource = dtByParkScanInfo;
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectParkingStatus))
                {
                    ParkingBase parkingBase = new ParkingBase();
                    if (rdr.Read())
                    {
                        parkingBase.TREATMENT_NO = rdr["TREATMENT_NO"].ToString();
                        parkingBase.Car_No = rdr["CAR_NO"].ToString();
                        parkingBase.IsLoaded = rdr["ISLOADED"]==DBNull.Value?999999: Convert.ToInt32(rdr["ISLOADED"]);
                        parkingBase.LASER_COUNT = rdr["LASER_ACTION_COUNT"]==DBNull.Value?999999:Convert.ToInt32(rdr["LASER_ACTION_COUNT"]);
                        parkingBase.PackingStatus = rdr["PARKING_STATUS"]==DBNull.Value?999999: Convert.ToInt32(rdr["PARKING_STATUS"]);
                    }
                    parkingStatusControl1.RefreshData(parkingBase);
                    
                }

            }
            catch (Exception)
            {

                throw ;
            }

        }

        //private void timer_RefreshOrder_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (tabActived == false)
        //        {

        //            return;
        //        }
        //        if (this.Height < 10)
        //        {
        //            return;
        //        }
        //        //刷新人工指令
        //        using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectManualOrder))
        //        {
        //            TCraneOrderInfo  craneOrderInfo = new TCraneOrderInfo();
        //            if (rdr.Read())
        //            {
        //                craneOrderInfo.OBJECT_TYPE = rdr["ORDER_TYPE"].ToString();
        //                craneOrderInfo.FROM_STOCK_NO = rdr["FROM_STOCK_NO"].ToString();
        //                craneOrderInfo.TO_STOCK_NO = rdr["TO_STOCK_NO"].ToString();
        //                craneOrderInfo.CMD_STATUS = rdr["CMD_STATUS"].ToString();
        //                craneOrderInfo.FROM_STOCK_X =rdr["FROM_STOCK_X"]==DBNull.Value?999999: Convert.ToInt32(rdr["FROM_STOCK_X"]);
        //                craneOrderInfo.FROM_STOCK_Y = rdr["FROM_STOCK_Y"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["FROM_STOCK_Y"]);
        //                craneOrderInfo.FROM_STOCK_Z = rdr["FROM_STOCK_Z"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["FROM_STOCK_Z"]);
        //                craneOrderInfo.TO_STOCK_X = rdr["TO_STOCK_X"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["TO_STOCK_X"]);
        //                craneOrderInfo.TO_STOCK_Y= rdr["TO_STOCK_Y"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["TO_STOCK_Y"]);
        //                craneOrderInfo.TO_STOCK_Z= rdr["TO_STOCK_Z"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["TO_STOCK_Z"]);

        //            }
        //           orderByManualControl1.RefreshData(craneOrderInfo);
        //        }
        //        ////刷新行车当前指令
        //        //using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectCurrentOrder))
        //        //{
        //        //    TCraneOrderInfo craneOrderInfo = new TCraneOrderInfo();
        //        //    if (rdr.Read())
        //        //    {
        //        //        craneOrderInfo.ORDER_NO = rdr["ORDER_NO"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["ORDER_NO"]);
        //        //        craneOrderInfo.ORDER_TYPE = rdr["ORDER_TYPE"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["ORDER_TYPE"]);
        //        //        craneOrderInfo.OBJECT_TYPE = rdr["OBJECT_TYPE"].ToString();
        //        //        craneOrderInfo.FROM_STOCK_NO = rdr["FROM_STOCK_NO"].ToString();
        //        //        craneOrderInfo.TO_STOCK_NO = rdr["TO_STOCK_NO"].ToString();
        //        //        craneOrderInfo.MAT_NO_1 = rdr["MAT_NO"].ToString();
        //        //        craneOrderInfo.MAT_NO_2 = rdr["MAT_NO_1"].ToString();
        //        //        craneOrderInfo.CMD_STATUS = rdr["CMD_STATUS"].ToString();
        //        //        craneOrderInfo.FROM_STOCK_X = rdr["PLAN_UP_X"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_UP_X"]);
        //        //        craneOrderInfo.FROM_STOCK_Y = rdr["PLAN_UP_Y"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_UP_Y"]);
        //        //        craneOrderInfo.FROM_STOCK_Z = rdr["PLAN_UP_Z"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_UP_Z"]);
        //        //        craneOrderInfo.TO_STOCK_X = rdr["PLAN_DOWN_X"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_DOWN_X"]);
        //        //        craneOrderInfo.TO_STOCK_Y = rdr["PLAN_DOWN_Y"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_DOWN_Y"]);
        //        //        craneOrderInfo.TO_STOCK_Z = rdr["PLAN_DOWN_Z"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_DOWN_Z"]);

        //        //    }
        //        //    orderByCurrentControl1.RefreshData(craneOrderInfo);
        //        //}
        //        //刷新L3指令
        //        dtByL3Order.Clear();
        //        using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectL3Order))
        //        {
        //            dtByL3Order.Load(rdr);
        //            //TCraneOrderInfo craneOrderInfo = new TCraneOrderInfo();
        //            //if (rdr.Read())
        //            //{
        //            //    craneOrderInfo.ORDER_NO = rdr["CRANE_GROUP_NO"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["CRANE_GROUP_NO"]);
        //            //    craneOrderInfo.ORDER_TYPE_L3 = rdr["ORDER_TYPE"] == DBNull.Value ? "未知":rdr["ORDER_TYPE"].ToString();
        //            //    //craneOrderInfo.OBJECT_TYPE = rdr["OBJECT_TYPE"].ToString();
        //            //    craneOrderInfo.LAYER_NO = rdr["FROM_LAYER"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["FROM_LAYERE"]);
        //            //    craneOrderInfo.FROM_STOCK_NO = rdr["FROM_STOCK_NO"].ToString();
        //            //    craneOrderInfo.TO_STOCK_NO = rdr["TO_STOCK_NO"].ToString();
        //            //    craneOrderInfo.MAT_NO_1 = rdr["MAT_NO_1"].ToString();
        //            //    craneOrderInfo.MAT_NO_2 = rdr["MAT_NO_2"].ToString();
        //            //    craneOrderInfo.CMD_STATUS = rdr["FLAG"].ToString()=="1"?"待作业":rdr["FLAG"].ToString() == "2" ? "作业中":"未知";
        //            //    craneOrderInfo.FROM_STOCK_X = rdr["X"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["X"]);
        //            //    craneOrderInfo.FROM_STOCK_Y = rdr["Y"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["Y"]);
        //            //    craneOrderInfo.FROM_STOCK_Z = rdr["Z"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["Z"]);
        //            //    //craneOrderInfo.TO_STOCK_X = rdr["PLAN_DOWN_X"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_DOWN_X"]);
        //            //    //craneOrderInfo.TO_STOCK_Y = rdr["PLAN_DOWN_Y"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_DOWN_Y"]);
        //            //    //craneOrderInfo.TO_STOCK_Z = rdr["PLAN_DOWN_Z"] == DBNull.Value ? 999999 : Convert.ToInt32(rdr["PLAN_DOWN_Z"]);

        //            //}
        //            dgvByL3Order.DataSource= dtByL3Order;
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //激光扫描
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定激光扫描"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {              
                using (IDataReader rdrd = DBHelper.ExecuteReader(_sqlCmdSelectCMDSTATUS))
                {
                    if (rdrd.Read())
                    {
                        CMD_STATUSD = rdrd["CMD_STATUS"].ToString();
                    }
                }
                if (CMD_STATUSD == "EMPTY")
                {
                    TagDP.SetData("EV_PARKING_LASERSTART", "86|CC1TV01");
                    string TextValue = "激光扫描";
                    InsertRecord(TextValue);
                }
                else
                {
                    MessageBox.Show("指令存在，请勿重新下达指令","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                }
             
            }
        }
        //车到达
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定车到达"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("EV_PARKING_CARARRIVE", "CC1TV01|TEST001|0");
                string TextValue = "车到达";
                InsertRecord(TextValue);
            }
        }
        //车离开
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定车离开"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("EV_PARKING_CARLEAVE", "CC1TV01");
                string TextValue = "车离开";
                InsertRecord(TextValue);
            }
        }

        //private void timer_RefreshUnit_Tick(object sender, EventArgs e)
        //{

        //    if (tabActived == false)
        //    {

        //        return;
        //    }
        //    if (this.Height < 10)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        //using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectLineUnitInfo))
        //        //{
        //        //    //TCraneOrderInfo craneOrderInfo = new TCraneOrderInfo();
        //        //    for (int i = 0; i < lstLineSlabInfos.Count; i++)
        //        //    {
        //        //        lstLineSlabInfos[i].ClearInfo();
        //        //    }

        //        //    while (rdr.Read())
        //        //    {
        //        //        for (int i = 0; i < lstLineSlabInfos.Count; i++)
        //        //        {
        //        //            if (lstLineSlabInfos[i].STOCK_NO == rdr["STOCK_NO"].ToString())
        //        //            {
        //        //                lstLineSlabInfos[i].MAT_NO_1 = rdr["MAT_NO_1"].ToString();
        //        //                lstLineSlabInfos[i].MAT_NO_2 = rdr["MAT_NO_2"].ToString();
        //        //                lstLineSlabInfos[i].X = rdr["X"].ToString();
        //        //                lstLineSlabInfos[i].Y = rdr["Y"].ToString();
        //        //                lstLineSlabInfos[i].Z = rdr["Z"].ToString();
        //        //                //lstLineSlabInfos[i].TREATMENT_NO = rdr["TREATMENT_NO"].ToString();
        //        //                //lstLineSlabInfos[i].ENABLE_FLAG = rdr["ENABLE"].ToString();
        //        //                break;
        //        //            }
        //        //        }
        //        //    }
        //        //    lineSlabInfoControl1.RefreshData(lstLineSlabInfos);
        //        //}




        //        dtByUnitScanInfo.Clear();
        //        using (IDataReader rdr = DBHelper.ExecuteReader(_sqlCmdSelectUnitLaser))
        //        {
        //            dtByUnitScanInfo.Load(rdr);
        //            dgvByUnitScan.DataSource = dtByUnitScanInfo;
        //        }
        //        inDatas.Clear();
        //        inData.Clear();
        //        TagDP.GetData(arrTagAdress, out inDatas);
        //        TagDP.GetData(arrTagAdressd, out inData);
        //        lblUnitLockStatus.Text = inDatas["LINE_EXIT_LOCK_STATUS"].ToString() == "1" ? "未锁定" : inDatas["LINE_EXIT_LOCK_STATUS"].ToString() == "0" ? "锁定" : "未知";
        //        // inDatas.ContainsKey(Key);
        //        //  inDatas.ContainsValue(value);
        //        lblUnitLockStatus.BackColor = inDatas["LINE_EXIT_LOCK_STATUS"].ToString() == "1" ? Color.Brown : inDatas["LINE_EXIT_LOCK_STATUS"].ToString() == "0" ? Color.DarkGreen : Color.Red;
        //        LineActionStatus.Text=inData ["LINE_EXIT_ACTION_STATUS"].ToString() == "1" ? "移动" : inData["LINE_EXIT_ACTION_STATUS"].ToString() == "0" ? "静止" : "未知";
        //        LineActionStatus.BackColor = inData["LINE_EXIT_ACTION_STATUS"].ToString() == "1" ? Color.Lime : inData["LINE_EXIT_ACTION_STATUS"].ToString() == "0" ? Color.Tomato : Color.Red;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show(ex.Message);
        //        throw;
        //    }

        //}
        //锁定
        private void btnUnitLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定锁定"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_EXIT_LOCK", "1");
                string TextValue = "锁定";
                InsertRecord(TextValue);
            }
        }
        //取消锁定
        private void btnUnitUnLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定解锁"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_EXIT_LOCK", "0");
                string TextValue = "取消锁定";
                InsertRecord(TextValue);
            }
        }

        private void conCraneStatus86_Load(object sender, EventArgs e)
        {

        }

        private void lineSlabInfoControl1_Load(object sender, EventArgs e)
        {

        }

        private void lineSlabInfoControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvByL3Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_TrainParking_Tick(object sender, EventArgs e)
        {
            //if (tabActived == false)
            //{

            //    return;
            //}
            //if (this.Height < 10)
            //{
            //    return;
            //}

            //try
            //{
            //    using (IDataReader rdrm = DBHelper.ExecuteReader(_sqlCmdSelecttrainParking))
            //    {
            //        for (int i = 0; i < lstLineSlabInfod.Count; i++)
            //        {
            //            lstLineSlabInfod[i].ClearInfo();
            //        }
            //        while (rdrm.Read())
            //        {
            //            for (int i = 0; i < lstLineSlabInfod.Count; i++)
            //            {
            //                if (lstLineSlabInfod[i].PARK_POS == rdrm["PARK_POS"].ToString())
            //                {
            //                    lstLineSlabInfod[i].LOAD_FLAG = rdrm["LOAD_FLAG"].ToString();
            //                    lstLineSlabInfod[i].STOCK_STATUS = rdrm["STOCK_STATUS"].ToString();
            //                    break;
            //                }
            //            }
            //        }
            //        trainParkingControl1.RefreshData(lstLineSlabInfod);
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //try
            //{
            //    using (IDataReader rdrs = DBHelper.ExecuteReader(_sqlCmdSelectManualInfo))
            //    {
            //        for (int i = 0; i < ManualInfos.Count; i++)
            //        {
            //            ManualInfos[i].ClearInfo();
            //        }
            //        while (rdrs.Read())
            //        {
            //            for (int i = 0; i < ManualInfos.Count; i++)
            //            {
            //                if (ManualInfos[i].STOCK_NO == rdrs["STOCK_NO"].ToString())
            //                {
            //                    ManualInfos[i].MAT_NO_1 = rdrs["MAT_NO_1"].ToString();
            //                    ManualInfos[i].MAT_NO_2 = rdrs["MAT_NO_2"].ToString();
            //                    ManualInfos[i].X = rdrs["DEFAULT_X"].ToString();
            //                    ManualInfos[i].Y = rdrs["DEFAULT_Y"].ToString();
            //                  //  ManualInfos[i].Z = rdrs["STOCK_SEQ"].ToString();
                    
            //                    break;
            //                }
            //            }
            //        }
            //    manualControl1.RefreshData(ManualInfos);
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定清空1号库位"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_IMAGE_CLEAR_FLAG", "1");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定清空2号库位"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_IMAGE_CLEAR_FLAG", "2");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定清空3号库位"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_IMAGE_CLEAR_FLAG", "3");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定清空4号库位"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_IMAGE_CLEAR_FLAG", "4");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定清空5号库位"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagDP.SetData("LINE_IMAGE_CLEAR_FLAG", "5");
            }
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timerCrane_Tick(object sender, EventArgs e)
        {

        }
    }
}
