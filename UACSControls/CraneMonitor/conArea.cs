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
using System.Media;
using UACSPopupForm;
using Baosight.iSuperframe.Forms;
using System.Reflection;
using System.Net;

namespace UACSControls
{
    public partial class conArea : UserControl
    {
        //跳转画面
        private Baosight.iSuperframe.Authorization.Interface.IAuthorization auth;
        private Label lbl = new Label();

        private Label lb2 = new Label();
        private Label lb3 = new Label();
        private AreaInfo areaInfo = new AreaInfo();
        private AreaBase areaBase = new AreaBase();
        private AreaBase thesaddle = new AreaBase();
        private AreaRowInfo rowInfo = new AreaRowInfo();
        private CraneStatusBase craneStatusBase = new CraneStatusBase();
        private static FrmSaddleShow frmSaddleShow = null;
        private static Form_CareMessage02 form_CareMessage02 = null;
        private static Form_UpdateLineSlabinfo form_UpdateLineSlabinfo = null;
      //  private static FrmParkingStatusShow frmParkingStatusShow=null ;
        private bool isCreateLbl = false;
        private string lblRuler;
        public static string CareInitt;
        public string CMD_STATUSD;//

        string _sqlCmdSelectCMDSTATUS = "SELECT CMD_STATUS FROM UACS_CRANE_MANU_ORDER where CRANE_NO='86'";

        public conArea()
        {
            InitializeComponent();
            this.Load += conArea_Load;
        }

        private int _angle = 0;
        [Browsable(true)]
        [Description("角度"), Category("自定义")]
        public int angle
        {
            get
            {
                return this._angle;
            }
            set
            {
                this._angle = value;

                this.Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float w = Width;
            float h = Height;
            //将graphics坐标原点移到矩形中心点
            g.TranslateTransform(w / 2, h / 2);
            g.RotateTransform(_angle);
            //SizeF sz = g.MeasureString(Text, this.Font);
            //float x = -sz.Width / 2;
            //float y = -sz.Height / 2;
            //Brush brush = new SolidBrush(this.ForeColor);
            //g.DrawString(Text, this.Font, brush, new PointF(x, y));
            g.TranslateTransform(-w / 2, -h / 2);
            base.OnPaint(e);
        }

        private  void Rotate_Paint(object sender,PaintEventArgs e)
        {
          
        }

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
        //记录吊盖当前操作保温坑信息
        public void toolStripMenuItemUpuer()
        {
            //获取当前时间
            string MeText = "吊盖" + areaBase.Area_Name;
            string  date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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

                        string sql = @"insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('" + mIp + "','" + MeText + "','"+date+"')";
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
        //记录卸盖当前操作保温坑信息
        public void toolStripMenuItemDown()
        {
            //获取当前时间
            string MeText = "卸盖" + areaBase.Area_Name;
            string  date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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

                        string sql = @"insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('" + mIp + "','" + MeText + "','"+date+"')";
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
        /// <summary>
        ///判断指令是否存在
        /// </summary>
        /// <param name="CMD_STATUS"></param>
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; //Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }
        void conArea_Load(object sender, EventArgs e)
        {
            auth = FrameContext.Instance.GetPlugin<IAuthorization>() as IAuthorization;
        }
        public delegate void areaRefreshInvoke(AreaBase theSaddle, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, Panel panel, conArea _conArea);
        // 正式绘图
        public void refreshControl(AreaBase theSaddle, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, Panel panel, conArea _conArea)
        {
            try
            {
                areaBase = theSaddle;
                //计算框的实际宽度所占比例
                double xScale = Convert.ToDouble(panelWidth) / Convert.ToDouble(baySpaceX);


                double location_X = 0;
                //判断库区的x坐标起始位置
                if (xAxisRight == true)
                {
                    //计算库区平面上位置宽度
                    location_X = Convert.ToDouble(theSaddle.X_Start) * xScale;
                }
                else
                {
                    //计算反方向库区平面上位置宽度
                    location_X = Convert.ToDouble(baySpaceX - (theSaddle.X_End)) * xScale;
                }
                //计算y方向上的比例关系
                double yScale = Convert.ToDouble(panelHeight) / Convert.ToDouble(baySpaceY);

                double location_Y = 0;
                //判断Y反向的起始位置
                if (yAxisDown == true)
                {
                    //计算y方向位置高度
                    location_Y = Convert.ToDouble(theSaddle.Y_Start) * yScale;
                }
                else
                {
                    //计算y反方向位置高度
                    location_Y = Convert.ToDouble(baySpaceY - (theSaddle.Y_End)) * yScale;
                }
                if (location_Y < 0)
                {
                    location_Y = 0;
                }

                //定位库区的坐标
                //控件的位置
                this.Location = new Point(Convert.ToInt32(location_X), Convert.ToInt32(location_Y));

                //设置鞍座控件的宽度
                this.Width = Convert.ToInt32((theSaddle.X_End - theSaddle.X_Start) * xScale);
                //设置鞍座控件的高度
                this.Height = Convert.ToInt32((theSaddle.Y_End - theSaddle.Y_Start) * yScale);

                //当控件的宽小于1时 不显示控件
                //if (this.Width < 1)
                //{
                //    this.Visible = false;
                //}
                switch ((AreaInfo.AreaType)areaBase.AreaType)
                {
                    //保温坑    10
                    case AreaInfo.AreaType.HotPitArea:
                        BackColor = Color.Silver;
                        break;                
                    //机组区  15
                    case AreaInfo.AreaType.AircrewArea:
                        BackColor = Color.SeaGreen;
                        break;
                    //安全线  6
                    case AreaInfo.AreaType.SecurityLine:
                        BackColor = Color.Yellow;
                        this.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        break;
                    //通道区 1
                    case AreaInfo.AreaType.PassagewagArea:
                        BackgroundImage = Resource1.RailWay;
                        break;
                    //临时区 9
                    case AreaInfo.AreaType.TemporaryArea:
                        BackColor = Color.CadetBlue;
                        break;
                    //保温坑盖堆放区
                    case AreaInfo.AreaType.HotPitCoverTemp:
                        if (areaBase.STOCK_STATUS == "EMPTY")
                        {
                            BackColor = Color.AliceBlue ;
                         
                        }
                        else
                        {
                            this.BackgroundImage = Resource1.havegai;
                        }                     
                        break;
                        ///火车盖区域
                    case AreaInfo.AreaType.TrainCoverTemp:
                        if (areaBase.STOCK_STATUS == "EMPTY")
                        {
                            BackColor = Color.AliceBlue;
                        }
                        else
                        {
                            this.BackgroundImage = Resource1.havegai;
                        }                
                        break;
                    case AreaInfo.AreaType.UnitArea:
                        BackColor = Color.DarkSeaGreen;
                        break;
                    // 安全门
                    case AreaInfo.AreaType.SecurityDoor:
                        string[] sArray = areaBase.AreaNo.Split('_');
                        string index = sArray[sArray.Length - 1];
                        const string  TagName = "SAFE_DOOR_Lock";
                        string safe_door_status = String.Empty;
                        Bitmap bitmap = null;
                        switch (TagName+index)
                        {
                            case "SAFE_DOOR_Lock1": safe_door_status = areaBase.Safe_door1.ToString(); break;
                            case "SAFE_DOOR_Lock2": safe_door_status = areaBase.Safe_door2.ToString();break;
                            case "SAFE_DOOR_Lock13": safe_door_status = areaBase.Safe_door2.ToString(); break;
                            case "SAFE_DOOR_Lock14": safe_door_status = areaBase.Safe_door2.ToString();break;
                            case "SAFE_DOOR_Lock15": safe_door_status = areaBase.Safe_door2.ToString(); break;
                        }
                        
                        if (safe_door_status == "2" || safe_door_status == "0")
                        {
                            this.BackgroundImage = Resource1.SDoorClose;
                            bitmap = Resource1.SDoorClose;


                        }
                        else
                        {
                            this.BackgroundImage = Resource1.SDoorOpen;
                            bitmap = Resource1.SDoorOpen;
                        }
                        

                        if(areaBase.Area_Name == "RightDoor") 
                        {
                            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            int temp = this.Height;
                            this.Height = this.Width;
                            this.Width = temp;
                            BackgroundImage = bitmap;

                        }
                        break;
                    //保温盖
                    case AreaInfo.AreaType.HotPitCoverArea:
                    case AreaInfo.AreaType.TrainCoverArea:                   
                        //BringToFront();
                        this.Visible = areaBase.AreaType == Convert.ToInt32(AreaInfo.AreaType.TrainCoverArea) && areaBase.ENABLE_FLAG != "1" ? false : true;
                        ContextMenuStrip = contextMenuStrip1;
                        if (areaBase.STOCK_STATUS == AreaInfo.STOCK_EMPTY_STATUS)
                        {
                            contextMenuStrip1.Items[0].Visible = false;
                            contextMenuStrip1.Items[1].Visible = true;
                            //BackColor = Color.AliceBlue;
                            BackgroundImage = Resource1.OutOpen;
                        }
                        else if (areaBase.STOCK_STATUS == AreaInfo.STOCK_OCCUPY_STATUS)
                        {
                            contextMenuStrip1.Items[0].Visible = true;
                            contextMenuStrip1.Items[1].Visible = false;
                         //   BackColor = Color.Brown;
                            BackgroundImage = Resource1.havegai;
                        }
                        else
                        {
                            contextMenuStrip1.Items[0].Visible = false;
                            contextMenuStrip1.Items[1].Visible = false;
                            BackColor = Color.Yellow;
                         

                        }
                        break;
                    case AreaInfo.AreaType.TrainParkingArea:
                       BackgroundImage = Resource1.RailWay;             
                        break;

                    default:
                        break;
                }
                //红区
                if (areaBase.Area_Name == "ReadA")
                {
                    if (areaBase.SAFE_AREA_1_Value.ToString() == "0")
                    {
                        this.BackColor = Color.Transparent;
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                    }

                }
                else if (areaBase.Area_Name == "ReadB")
                {
                    if (areaBase.SAFE_AREA_2_Value.ToString() == "0")
                    {
                        this.BackColor = Color.Transparent;
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                    }
                }
                else if (areaBase.Area_Name == "ReadC" || areaBase.Area_Name == "ReadD")
                {
                    if (areaBase.SAFE_AREA_3_Value.ToString() == "0")
                    {
                        this.BackColor = Color.Transparent;
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                    }
                }           
                //安全门
               // if (areaBase.Area_Name == "LeftDoor")
               // {
               //     if (areaBase.Safe_door4.ToString() == "2" || areaBase.Safe_door4.ToString() == "0")
               //     {
               //        this.BackgroundImage = Resource1.SDoorClose;
                        
               //     }
               //     else
               //     {
               //         this.BackgroundImage = Resource1.SDoorOpen;
               //     }
               // }
               //else  if (areaBase.Area_Name == "TopDoor")
               // {
               //     if (areaBase.Safe_door4 .ToString () == "2" || areaBase.Safe_door4.ToString() == "0")
               //     {
               //        // this._angle = 90;
               //         this.BackgroundImage = Resource1.SDoorClose;
               //     }
               //     else
               //     {
               //         this.BackgroundImage = Resource1.SDoorOpen;

               //     }

               // }
               // else if(areaBase.Area_Name == "RightDoor")
               // {
               //     if (areaBase.Safe_door4.ToString() == "2" || areaBase.Safe_door4.ToString() == "0")
               //     {
               //         Bitmap bitmap = Resource1.SDoorClose;
               //         bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
               //         int temp = this.Height;
               //         this.Height = this.Width;
               //         this.Width = temp;
               //         BackgroundImage = bitmap;
                        
               //     }
               //     else
               //     {
               //         Resource1.SDoorClose.RotateFlip(RotateFlipType.Rotate90FlipNone);
               //         this.BackgroundImage = Resource1.SDoorOpen;
               //     }

               // }
               // else if (areaBase.Area_Name == "BottomDoor")
               // {
               //     if (areaBase.Safe_door4.ToString() == "2" || areaBase.Safe_door4.ToString() == "0")
               //     {
               //         BackgroundImage = Resource1.SDoorClose;
               //     }
               //     else
               //     {
               //         this.BackgroundImage = Resource1.SDoorOpen;
               //     }

               // }
                //if (theSaddle.AreaType == 5)
                //{
                //    this.BackColor = Color.DarkSeaGreen;

                //}
                #region
                ////盖区
                //if (theSaddle.AreaType == 4)
                //{
                //    //if (!isCreateLbl)
                //    //{
                //    //    lbl.Name = theSaddle.AreaNo;
                //    //    lbl.BackColor = Color.MediumAquamarine;
                //    //    lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //    //    lbl.Width = 95;
                //    //    lbl.Height = 30;
                //    //    lbl.ForeColor = Color.Black;
                //    //    lbl.Click += conArea_Click;
                //    //    _conArea.Controls.Add(lbl);

                //    //    // List<int> list = rowInfo.getAreaNoRow(areaBase.AreaNo) as List<int>;
                //    //    // lblRuler = rowInfo.getAreaRowsInfo(list);

                //    //    isCreateLbl = true;
                //    //}
                //    ////if (panel.Width < 1400)
                //    ////{
                //    ////    lbl.Width = 95;
                //    ////    lbl.Height = 35;
                //    ////    //lbl.Text = lblRuler;
                //    ////}
                //    ////else
                //    ////{
                //    //    lbl.Width = 70;
                //    //    lbl.Height = 30;
                //    //    lbl.Text = "坑盖数：" + theSaddle.AreaSaddleNum + "\n";
                //    //       //  + "白库位：   " + theSaddle.AreaSaddleNoCoilNum + "\n"
                //    //       //  + "黑库位：   " + theSaddle.AreaSaddleCoilNum + "\n"
                //    //       //+ "方坯号：   " + (theSaddle.AreaSaddleNum - theSaddle.AreaSaddleNoCoilNum - theSaddle.AreaSaddleCoilNum);
                //    ////}
                //    ////设置显示的颜色(包括安全门)
                //    ////if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 0)
                //    ////    this.BackColor = System.Drawing.Color.Red;
                //    ////else if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 1)
                //    ////    this.BackColor = System.Drawing.Color.Blue;
                //    ////else if (theSaddle.AreaDoorSefeValue == 1 && theSaddle.AreaDoorReserveValue == 1)
                //    ////    this.BackColor = System.Drawing.Color.Yellow;
                //    ////else
                //    //this.BackColor = System.Drawing.Color.DarkSeaGreen;

                //    //lbl.Location = new Point(this.Width / 2-30, this.Height / 2+5);
                //    //lbl.BackColor = Color.AliceBlue;

                //}
                /////火车状态信息
                //if (theSaddle.AreaType == 3)
                //{
                //    if (!isCreateLbl)
                //    {
                //        lbl.Name = theSaddle.AreaNo;
                //        lbl.BackColor = Color.MediumAquamarine;
                //        lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //        lbl.Width = 95;
                //        lbl.Height = 15;
                //        lbl.ForeColor = Color.Black;
                //        lbl.Click += conArea_Click;
                //        _conArea.Controls.Add(lbl);
                //        // List<int> list = rowInfo.getAreaNoRow(areaBase.AreaNo) as List<int>;
                //        // lblRuler = rowInfo.getAreaRowsInfo(list);

                //        isCreateLbl = true;
                //    }
                //    //if (panel.Width < 1400)
                //    //{
                //    //    lbl.Width = 95;
                //    //    lbl.Height = 35;
                //    //    //lbl.Text = lblRuler;
                //    //}
                //    //else
                //    //{
                //    int parkingtype = theSaddle.Parking_STATUS;
                //    string Parking_Type = "";
                //    if(parkingtype==10)
                //    {
                //       // Parking_Type = "有车到达";
                //        Parking_Type = CraneStatusBase.btn_CarneArrive;
                //        lbl.ForeColor = System.Drawing.Color.Blue;
                //    }
                //    else if(parkingtype == 110)
                //    {
                //        Parking_Type = "激光扫描开始";
                //        lbl.ForeColor = System.Drawing.Color.Green;
                //    }
                //    else if(parkingtype == 120)
                //    {
                //        Parking_Type = "激光扫描结束";
                //        lbl.ForeColor = System.Drawing.Color.Yellow;
                //    }
                //    else if (parkingtype == 5)
                //    {
                //      //  Parking_Type = "车离开";
                //        Parking_Type = CraneStatusBase.btn_craneleave;
                //        lbl.ForeColor = System.Drawing.Color.Orange;
                //    }
                //    else 
                //    {
                //        Parking_Type = "未知";
                //        lbl.ForeColor = System.Drawing.Color.IndianRed;
                //    }      
                //    lbl.Width =120;
                //    lbl.Height = 18;
                //    lbl.Text = "状态：" + Parking_Type + "\n";
                //    //  + "白库位：   " + theSaddle.AreaSaddleNoCoilNum + "\n"
                //    //  + "黑库位：   " + theSaddle.AreaSaddleCoilNum + "\n"
                //    //+ "方坯号：   " + (theSaddle.AreaSaddleNum - theSaddle.AreaSaddleNoCoilNum - theSaddle.AreaSaddleCoilNum);
                //    //}
                //    //设置显示的颜色(包括安全门)
                //    //if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 0)
                //    //    this.BackColor = System.Drawing.Color.Red;
                //    //else if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 1)
                //    //    this.BackColor = System.Drawing.Color.Blue;
                //    //else if (theSaddle.AreaDoorSefeValue == 1 && theSaddle.AreaDoorReserveValue == 1)
                //    //    this.BackColor = System.Drawing.Color.Yellow;
                //    //else
                //    this.BackColor = System.Drawing.Color.Transparent;

                //    lbl.Location = new Point(this.Width / 2-60, this.Height / 2-10);
                //    lbl.BackColor = this.BackColor;

                //}

                //坑区
                // if (theSaddle.AreaType == 10)
                // {
                //     if (!isCreateLbl)
                //     {
                //         lbl.Name = theSaddle.AreaNo;
                //         //lbl.Text = theSaddle.AreaNo;
                //       //  lbl.BackColor = Color.MediumAquamarine;
                //         lbl.Font = new System.Drawing.Font("微软雅黑", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
                //         lbl.Width = 95;
                //         lbl.Height = 30;
                //        lbl.ForeColor = Color.Black;
                //         lbl.Click += conArea_Click;
                //         _conArea.Controls.Add(lbl);

                //         // List<int> list = rowInfo.getAreaNoRow(areaBase.AreaNo) as List<int>;
                //         // lblRuler = rowInfo.getAreaRowsInfo(list);

                //         isCreateLbl = true;
                //     }
                //     if (panel.Width < 1400)
                //     {
                //         lbl.Width = 60;
                //         lbl.Height = 20;
                //         //lbl.Text = lblRuler;
                //     }
                //     else
                //     {
                //         //lbl.Width = 95;
                //         //lbl.Height = 50;
                //         //lbl.Text = "坯总数：" + theSaddle.AreaSaddleNum + "\n"
                //         //     + "坑盖：   " + theSaddle.AreaSaddleNoCoilNum + "\n"
                //         //  //  + "黑库位：   " + theSaddle.AreaSaddleCoilNum + "\n"
                //         //   + "方坯型号：   " + (theSaddle.AreaSaddleNum - theSaddle.AreaSaddleNoCoilNum - theSaddle.AreaSaddleCoilNum);
                //     }
                //     //设置显示的颜色(包括安全门)
                //     //if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 0)
                //     //    this.BackColor = System.Drawing.Color.Red;
                //     //else if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 1)
                //     //    this.BackColor = System.Drawing.Color.Blue;
                //     //else if (theSaddle.AreaDoorSefeValue == 1 && theSaddle.AreaDoorReserveValue == 1)
                //     //    this.BackColor = System.Drawing.Color.Yellow;
                //     //else
                //     // this.BackColor = System.Drawing.Color.DarkSeaGreen;
                //     this.BackColor = System.Drawing.Color.Transparent;
                ////  this.BackColor =System.Drawing.Color.
                //     lbl.Location = new Point(this.Width/2-20, this.Height /2-5);
                //    lbl.BackColor = this.BackColor;

                // }    
                //if (theSaddle.AreaType == 0)
                //{
                //    if (!isCreateLbl)
                //    {
                //        lbl.Name = theSaddle.AreaNo;
                //        lbl.BackColor = Color.MediumAquamarine;
                //        lbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //        lbl.Width = 95;
                //        lbl.Height = 100;
                //        lbl.ForeColor = Color.Black;
                //        lbl.Click += conArea_Click;
                //        _conArea.Controls.Add(lbl);

                //        // List<int> list = rowInfo.getAreaNoRow(areaBase.AreaNo) as List<int>;
                //        // lblRuler = rowInfo.getAreaRowsInfo(list);

                //        isCreateLbl = true;
                //    }

                //    if (panel.Width < 1400)
                //    {
                //        lbl.Width = 60;
                //        lbl.Height = 20;
                //        //lbl.Text = lblRuler;
                //    }
                //    else
                //    {
                //       lbl.Width = 95;
                //     lbl.Height = 100;
                //        lbl.Text = "鞍座总数：" + theSaddle.AreaSaddleNum + "\n"
                //             + "白库位：   " + theSaddle.AreaSaddleNoCoilNum + "\n"
                //            + "黑库位：   " + theSaddle.AreaSaddleCoilNum + "\n"
                //           + "红库位：   " + (theSaddle.AreaSaddleNum - theSaddle.AreaSaddleNoCoilNum - theSaddle.AreaSaddleCoilNum) ;
                //    }
                //    //设置显示的颜色(包括安全门)
                //    //if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 0)
                //    //    this.BackColor = System.Drawing.Color.Red;
                //    //else if (theSaddle.AreaDoorSefeValue == 0 && theSaddle.AreaDoorReserveValue == 1)
                //    //    this.BackColor = System.Drawing.Color.Blue;
                //    //else if (theSaddle.AreaDoorSefeValue == 1 && theSaddle.AreaDoorReserveValue == 1)
                //    //    this.BackColor = System.Drawing.Color.Yellow;
                //    //else
                //    this.BackColor = System.Drawing.Color.DarkSeaGreen;

                //    lbl.Location = new Point(this.Width / 2 - 30, this.Height / 2 - 20);
                //    lbl.BackColor = this.BackColor;
                //}
                //else if (theSaddle.AreaNo == "TRAINCAP3") //火车尾3
                //{
                //    //  is.BackColor = Color.DimGray;
                //    this.BackColor = Color.LightSlateGray;
                //    this.BackgroundImage = global::UACSControls.Resource1.Care3;

                //}
                //else if (theSaddle.AreaNo == "TRAINCAP1") //火车头
                //{
                //    // this.BackColor = Color.DimGray;
                //    this.BackColor = Color.LightSlateGray;
                //    this.BackgroundImage = global::UACSControls.Resource1.Care1;

                //}
                //else if (theSaddle.AreaNo == "TRAINCAP2") //火车尾2
                //{
                //    // this.BackColor = Color.DimGray;
                //    this.BackColor = Color.LightSlateGray;
                //    this.BackgroundImage = global::UACSControls.Resource1.Care2;
                //}
                //else if (theSaddle.AreaType == 1) //通道
                //{
                //    this.BackColor = Color.White;
                //    this.BackgroundImage = global::UACSControls.Resource1.Carecar;

                //}
                //else if (theSaddle.AreaType == 3)//火车状态信息
                //{
                //    this.BackColor = Color.White;


                //}
                //else if (theSaddle.AreaType == 15) //机组
                //{
                //    this.BackColor = Color.MediumSeaGreen;

                //}
                //else if (theSaddle.AreaType == 5) //区域
                //{

                //    if (areaBase.STOCK_STATUS == "1")
                //    {
                //        this.BackColor = Color.Gray;

                //    }
                //    else if (areaBase.STOCK_STATUS == "0")
                //    {

                //        this.BackColor = Color.DarkSeaGreen;

                //    }
                //    else
                //    {
                //        this.BackColor = Color.Red;

                //    }
                //    // this.BackColor = Color.DarkOliveGreen;
                //    // this.lbl.BackColor = Color.DarkOliveGreen;
                //    //  this.BackgroundImage = global::UACSControls.Resource1.盖1;

                //}
                //else if (theSaddle.AreaType == 4) //坑盖区
                //{
                //    this.BackColor = Color.DarkSeaGreen;

                //}
                //else if (theSaddle.AreaType == 11) //安全栏
                //{
                //    this.BackColor = Color.Yellow;
                //    // this.BackgroundImage = global::UACSControls.Resource1.anquanlan_3;
                //}

                //else if (theSaddle.AreaType == 7) //安全门上开
                //{
                //    this.BackColor = Color.DarkGray;
                //    this.BackgroundImage = global::UACSControls.Resource1.NCarEmpty;
                //    //D:\无人行车项目\项目开发资料\无人行车项目\新建文件夹新版\新建文件夹 (3)\UACSControls\img\NCarEmpty.png
                //}
                //else if (theSaddle.AreaType == 8) //安全门左开
                //{
                //    this.BackColor = Color.DarkGray;
                //    this.BackgroundImage = global::UACSControls.Resource1._1;
                //    //D:\无人行车项目\项目开发资料\无人行车项目\新建文件夹新版\新建文件夹 (3)\UACSControls\img\NCarEmpty.png
                //}
                //else if (theSaddle.AreaType == 13)  //运输链
                //{
                //    this.BackColor = Color.SandyBrown;
                //    this.BackgroundImage = global::UACSControls.Resource1.Ca;
                //    lbl.Text = "运输链";
                //}
                //else if (theSaddle.AreaType == 9)  //临时架
                //{
                //    this.BackColor = Color.CornflowerBlue;
                //}
                ////else if (theSaddle.AreaType == 4)  //机组出口
                ////{
                ////    this.BackColor = Color.MediumPurple;
                ////    lbl.Text = "机组出口";
                ////}
                //else if (theSaddle.AreaType == 10)  //机组入口
                //{
                //    this.BackColor = Color.MediumSlateBlue;
                //    //   this.Width = Convert.ToInt32(this.Width * 1.3);
                //    // this.Height = Convert.ToInt32(this.Height * 1.3);
                //    //   lbl.Text = "机";
                //}            
                //else
                //{
                //    this.BackColor = Color.Coral;
                //    // this.BackColor = System.Drawing.Color.Transparent;
                //}
                #endregion
            }
            catch (Exception ex)
            {
                LogManager.WriteProgramLog(ex.Message);
                LogManager.WriteProgramLog(ex.StackTrace);
            }
        }
        public delegate void EventHandler_Saddle_Selected(AreaBase theSaddleInfo);
        public event EventHandler_Saddle_Selected Saddle_Selected;

        //public static SolidBrush NO_COVER_BRUSH = new SolidBrush(Color.White);
        public static Pen pByAliceBlue= new Pen(Color.AliceBlue,2);
        public static Pen pByDefault = new Pen(Color.Gray, 3);


        public static SolidBrush fontColorLight = new SolidBrush(Color.White);
        public static SolidBrush fontColorDark = new SolidBrush(Color.Black);
        public static SolidBrush fontColorRed = new SolidBrush(Color.Red);
        //public static SolidBrush UNKOWN_COVER_BRUSH = new SolidBrush(Color.Yellow);
        private void conArea_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics gr = e.Graphics;
                Graphics grm = e.Graphics;
                Graphics grd = e.Graphics;
                Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                Pen p = pByDefault;
                SolidBrush sb = fontColorDark;
                string strTitle = string.Empty;
                string strTitle2 = string.Empty;
                string strTitle3 = string.Empty;
                switch ((AreaInfo.AreaType)areaBase.AreaType)
                {
                    //保温盖
                    case AreaInfo.AreaType.HotPitCoverArea:
                    case AreaInfo.AreaType.TrainCoverArea:
                        p = pByAliceBlue;
                        strTitle = string.Format("区域:{0}\n状态:{1}\n", areaBase.Area_Name, areaBase.STOCK_STATUS == "EMPTY" ? "无保温盖" : areaBase.STOCK_STATUS == "OCCUPY" ? "有保盖" : "未知");
                        sb = areaBase.STOCK_STATUS == "EMPTY" ? fontColorDark : areaBase.STOCK_STATUS == "OCCUPY" ? fontColorLight : fontColorDark;      
                        break;
                    case AreaInfo.AreaType.HotPitArea:
                        break;
                    case AreaInfo.AreaType.UnitArea:
                        p = pByAliceBlue;
                        strTitle2 = string.Format("区域:台架区");
                        break;
                    case AreaInfo.AreaType.SecurityLine:
                        p = pByAliceBlue;
                        strTitle = string.Format("");
                        break;
                    case AreaInfo.AreaType.RedArea:
                        p = pByAliceBlue;
                        strTitle = string.Format("");
                        break;
                    //case AreaInfo.AreaType.SecurityDoor:
                    //    p = pByAliceBlue;
                    //    if(areaBase.Area_Name== "DoorB")
                    //    {
                    //        p = pByAliceBlue;
                    //        strTitle = string.Format("{0}",areaBase.STOCK_STATUS == "EMPTY" ? "开" : areaBase.STOCK_STATUS == "OCCUPY" ? "锁" : "?");
                    //        sb = areaBase.STOCK_STATUS == "EMPTY" ? fontColorRed : areaBase.STOCK_STATUS == "OCCUPY" ? fontColorDark : fontColorRed;
                    //    }
                    //    else
                    //    {
                    //        p = pByAliceBlue;
                    //        strTitle3 = string.Format("{0}",areaBase.STOCK_STATUS == "EMPTY" ? "开" : areaBase.STOCK_STATUS == "OCCUPY" ? "锁" : "?");
                    //        sb = areaBase.STOCK_STATUS == "EMPTY" ? fontColorRed : areaBase.STOCK_STATUS == "OCCUPY" ? fontColorDark : fontColorRed;
                    //    }                       
                    //    break;
                    case AreaInfo.AreaType.HotPitCoverTemp:
                        p = pByAliceBlue;
                        strTitle = string.Format("区域:{0}\n盖层数:{1}\n", areaBase.Area_Name,areaBase.ENABLE_NUM);
                        break;
                    case AreaInfo.AreaType.TrainCoverTemp:
                        p = pByAliceBlue;
                        strTitle = string.Format("区域:{0}\n状态:{1}\n", areaBase.Area_Name, areaBase.STOCK_STATUS == "EMPTY" ? "无保温盖" : areaBase.STOCK_STATUS == "OCCUPY" ? "有保盖" : "未知");
                        sb = areaBase.STOCK_STATUS == "EMPTY" ? fontColorDark : areaBase.STOCK_STATUS == "OCCUPY" ? fontColorLight : fontColorDark;
                        break;
                    case AreaInfo.AreaType.AircrewArea:
                    case AreaInfo.AreaType.TemporaryArea:
                        p = pByAliceBlue;
                        strTitle2 = string.Format("区域:{0}", areaBase.Area_Name);
                        break;
                    default:
                        break;
                }
                gr.DrawString(strTitle, new Font("微软雅黑", 8, FontStyle.Bold), sb, new Point(5, 5));
                grm.DrawString(strTitle2, new Font("微软雅黑", 10, FontStyle.Bold), sb, new Point(10, 10));
                //创建矩形对象
                grd.DrawString(strTitle3, new Font("微软雅黑", 10, FontStyle.Bold), sb, new Point(5,35));
                //创建矩形对象
                gr.DrawRectangle(p, rec);
                grm.DrawRectangle(p, rec);
                grd.DrawRectangle(p, rec);
                #region
                //if (areaBase.AreaType == 9)
                //{
                //    gr.DrawString(areaBase.Area_Name,
                //           new Font("微软雅黑", 14, FontStyle.Bold), Brushes.Blue, new Point(this.Width / 2 - 40, 20));

                //    //        //创建矩形对象                左上角度座标                 宽   高  
                //    Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //    gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                //}
                // //机组区域
                // if (areaBase.AreaType == 15)
                // {
                //     gr.DrawString(areaBase.Area_Name,
                //            new Font("微软雅黑", 14, FontStyle.Bold), Brushes.Blue, new Point(this.Width / 2 - 40, 20));

                //     //        //创建矩形对象                左上角度座标                 宽   高  
                //     Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //     gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                // }
                ////保温坑
                // if (areaBase.AreaType == 5)
                // {
                //     gr.DrawString(areaBase.Area_Name,
                //            new Font("微软雅黑", 12, FontStyle.Bold), Brushes.Blue, new Point(this.Width / 2 - 40,10));

                //     //        //创建矩形对象                左上角度座标                 宽   高  
                //     Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //     gr.DrawRectangle(new Pen(Color.Orange, 2), rec);

                //     //gr.DrawString("鞍座总数：" + thesaddle.AreaSaddleNum + "\n"
                //     //         + "白库位：   " + thesaddle.AreaSaddleNoCoilNum + "\n"
                //     //        + "黑库位：   " + thesaddle.AreaSaddleCoilNum,
                //     //     new Font("微软雅黑", 8, FontStyle.Regular), Brushes.Black, new Point(this.Width / 2-40, 40));

                //     ////        //创建矩形对象                左上角度座标                 宽   高  
                //     //Rectangle recs = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //     //gr.DrawRectangle(new Pen(Color.Orange, 2), recs);
                // }
                // //if (areaBase.AreaType == 1)
                // //{
                // //    e.Graphics.DrawString(areaBase.Area_Name, new Font("微软雅黑", 12, FontStyle.Regular), 
                // //        new SolidBrush(Color.Red), 1, 1, new StringFormat(StringFormatFlags.DisplayFormatControl));

                // //}
                // //台架区域
                // if (areaBase.AreaType == 10)
                // {
                //     gr.DrawString(areaBase.Area_Name,
                //            new Font("微软雅黑", 14, FontStyle.Bold), Brushes.Blue, new Point(this.Width / 2 - 40, 20));

                //     //        //创建矩形对象                左上角度座标                 宽   高  
                //     Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //     gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                // }
                // //临时区域
                // if (areaBase.AreaType == 9)
                // {
                //     gr.DrawString(areaBase.Area_Name,
                //            new Font("微软雅黑", 14, FontStyle.Bold), Brushes.Blue, new Point(this.Width / 2-50, 20));

                //     //        //创建矩形对象                左上角度座标                 宽   高  
                //     Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //     gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                // }
                // //火车
                // if (areaBase.Parking_STATUS != 5)
                // {
                //     if (areaBase.AreaType == 6)
                //     {

                //         int StP = areaBase.PSTOCK_STATUS;
                //         string StPText = "";
                //         if (StP == 2)
                //         {
                //             StPText = "有火车盖";
                //             gr.DrawString(StPText,
                //             new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Yellow, new Point(this.Width / 2 - 10, 8));

                //             //        //创建矩形对象                左上角度座标                 宽   高  
                //             Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //             gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                //         }
                //         else if (StP == 1)
                //         {
                //             StPText = "无火车盖";
                //             gr.DrawString(StPText,
                //             new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Orange, new Point(this.Width / 2 - 10, 8));

                //             //        //创建矩形对象                左上角度座标                 宽   高  
                //             Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //             gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                //         }
                //         else
                //         {
                //             StPText = "异常";
                //             gr.DrawString(StPText,
                //             new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Red, new Point(this.Width / 2 - 10, 8));

                //             //        //创建矩形对象                左上角度座标                 宽   高  
                //             Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //             gr.DrawRectangle(new Pen(Color.Orange, 2), rec);
                //         }
                //         // areaBase.Area_Name                
                //         //火车盖编号

                //         // gr.DrawString("火车盖编号：" + thesaddle.AreaSaddleNum,                          
                //         //      new Font("微软雅黑", 8, FontStyle.Regular), Brushes.Black, new Point(this.Width / 2-10, 25));
                //         //       //创建矩形对象                左上角度座标                 宽   高  
                //         // Rectangle recs = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //         //gr.DrawRectangle(new Pen(Color.Orange, 2), recs);

                //     }
                // }
                ////盖区
                //if (areaBase.AreaType == 4)
                //{
                //    gr.DrawString(string.Format("区域:{0}\n盖子:{1}\n",areaBase.Area_Name,areaBase.STOCK_STATUS),
                //           new Font("微软雅黑", 8, FontStyle.Bold), Brushes.Blue, new Point(5, 5));

                //    //        //创建矩形对象                左上角度座标                 宽   高  
                //    Rectangle rec = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                //    gr.DrawRectangle(new Pen(Color.AliceBlue, 2), rec);
                //}
                #endregion
            }
            catch (Exception er)
            {

            }
        }

        private void conArea_Click(object sender, EventArgs e)
        {
           if( areaBase.Area_Name == "UNIT_EXIT_AREA")
            {
               if (form_UpdateLineSlabinfo == null || form_UpdateLineSlabinfo.IsDisposed)
                {
                  form_UpdateLineSlabinfo = new Form_UpdateLineSlabinfo();

                    form_UpdateLineSlabinfo.Show();
               }
              else
              {
                    form_UpdateLineSlabinfo.WindowState = FormWindowState.Normal;
                    form_UpdateLineSlabinfo.Activate();
           }


            }
            //火车尾部车厢单击事件
           if (areaBase.AreaNo== "TRAINCAP3")
            {

                // Application.OpenForms["窗体名字"].Close();
                //if (frmModeSwitchover == null || frmModeSwitchover.IsDisposed)
                //{
                //    frmModeSwitchover = new FrmModeSwitchover();
                //    frmModeSwitchover.Crane_No = craneNO;
                //    frmModeSwitchover.TagServiceName = TagServiceName;
                //    frmModeSwitchover.Show();
                //}
                //else
                //{
                //    frmModeSwitchover.WindowState = FormWindowState.Normal;
                //}
                CareInitt = "第 三 节";

                // Form_CareMessage from = new UACSPopupForm.Form_CareMessage(CareInitt);
                //Form_CareMessage02 from = new UACSPopupForm.Form_CareMessage02(CareInitt);
                //from.Show();
                if (form_CareMessage02 == null || form_CareMessage02.IsDisposed)
                {
                    form_CareMessage02 = new Form_CareMessage02(CareInitt);
                  
                    form_CareMessage02.Show();
                }
                else
                {
                    form_CareMessage02.WindowState = FormWindowState.Normal;
                    form_CareMessage02.Activate();
                }
            }
           //火车中部车厢单击事件
           if(areaBase.AreaNo == "TRAINCAP2")
            {
                CareInitt = "第 二 节";
                //Form_CareMessage02 from = new UACSPopupForm.Form_CareMessage02(CareInitt);
                //from.Show();
                if (form_CareMessage02 == null || form_CareMessage02.IsDisposed)
                {
                    form_CareMessage02 = new Form_CareMessage02(CareInitt);

                    form_CareMessage02.Show();
                }
                else
                {
                    form_CareMessage02.WindowState = FormWindowState.Normal;
                    form_CareMessage02.Activate();
                }
            }
           //火车头部车厢单击事件
           if(areaBase.AreaNo == "TRAINCAP1")
            {
                CareInitt = "第 一 节";
                //Form_CareMessage02 from = new UACSPopupForm.Form_CareMessage02(CareInitt);
                //from.Show();
                if (form_CareMessage02 == null || form_CareMessage02.IsDisposed)
                {
                    form_CareMessage02 = new Form_CareMessage02(CareInitt);

                    form_CareMessage02.Show();
                }
                else
                {
                    form_CareMessage02.WindowState = FormWindowState.Normal;
                    form_CareMessage02.Activate();
                }
            }
             if(areaBase.AreaType == 3)
            {

                //if (frmParkingStatusShow == null || frmParkingStatusShow.IsDisposed)
                //{
                //    frmParkingStatusShow = new FrmParkingStatusShow();
                ////    frmSaddleShow.AreaBase = areaBase;
                //  frmParkingStatusShow.Show();
                //}
                //else
                //{
                //    frmParkingStatusShow.WindowState = FormWindowState.Normal;
                //    frmParkingStatusShow.Activate();
                //}
            }

            //if (areaBase.AreaType == 0)
            //{
            //    if (frmSaddleShow == null || frmSaddleShow.IsDisposed)
            //    {
            //        //frmSaddleShow = new FrmSaddleShow();
            //        //frmSaddleShow.AreaBase = areaBase;
            //        //frmSaddleShow.Show();
            //    }
            //    else
            //    {
            //        //frmSaddleShow.WindowState = FormWindowState.Normal;
            //        //frmSaddleShow.Activate();
            //    }
            //}
            //else if (areaBase.AreaNo.IndexOf("H145") > -1 && areaBase.AreaType == 4)
            //{
            //    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            //    DialogResult dr = MessageBox.Show("确定要切换到H145机组入口跟踪画面吗？", "操作提示", btn);
            //    if (dr == DialogResult.OK)
            //    {
            //        auth.OpenForm("H145入口");
            //    }
            //}
            //else if (areaBase.AreaNo.IndexOf("H145") > -1 && areaBase.AreaType == 5)
            //{
            //    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            //    DialogResult dr = MessageBox.Show("确定要切换到H145机组出口跟踪画面吗？", "操作提示", btn);
            //    if (dr == DialogResult.OK)
            //    {
            //        auth.OpenForm("H145出口");
            //    }
            //}
            //else if (areaBase.AreaType == 13)
            //{
            //    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            //    DialogResult dr = MessageBox.Show("确定要切换到-运输链-跟踪画面吗？", "操作提示", btn);
            //    if (dr == DialogResult.OK)
            //    {
            //        auth.OpenForm("运输链");
            //    }
            //}
            //else if (areaBase.AreaType == 999)
            //{
                //if (frmSaddleShow == null || frmSaddleShow.IsDisposed)
                //{
                //    frmSaddleShow = new FrmSaddleShow();
                //    frmSaddleShow.AreaBase = areaBase;
                //    frmSaddleShow.Show();
                //}
                //else
                //{
                //    frmSaddleShow.WindowState = FormWindowState.Normal;
                //    frmSaddleShow.Activate();
                //}
            //}
        }
        //吊盖
        private void toolStripMenuItemUpCover_Click(object sender, EventArgs e)
        {
          //  DialogResult dr = MessageBox.Show("确定有盖", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // if (dr == DialogResult.OK)
           // {
                if (MessageBox.Show(string.Format("是否确认区域{0}吊盖作业", areaBase.Area_Name), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                using (IDataReader rdrd =DB2Connect.DBHelper.ExecuteReader(_sqlCmdSelectCMDSTATUS))
                {
                    if (rdrd.Read())
                    {
                        CMD_STATUSD = rdrd["CMD_STATUS"].ToString();
                    }
                }
                if (CMD_STATUSD == "EMPTY")
                {
                    string Tran_Name = "";
                    if (areaBase.Area_Name == "1#" || areaBase.Area_Name == "2#" || areaBase.Area_Name == "3#")
                    {
                        Tran_Name = "1";
                        TagDP.SetData("EV_COVER_TASK", string.Format("{0}|0|{1}", areaBase.STOCK_NO, Tran_Name));
                        toolStripMenuItemUpuer();
                    }
                    else
                    {
                        Tran_Name = "2";
                        TagDP.SetData("EV_COVER_TASK", string.Format("{0}|0|{1}", areaBase.STOCK_NO, Tran_Name));
                        toolStripMenuItemUpuer();

                    }

                }
            else
            {
                MessageBox.Show("指令存在，请勿重新下达指令", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }     
                }
           // }
        }
        //卸盖
        private void toolStripMenuItemDownCover_Click(object sender, EventArgs e)
        {
            //DialogResult dr =MessageBox.Show("确定有盖", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // if(dr == DialogResult.OK)
            //   { 

            if (MessageBox.Show(string.Format("是否确认区域{0}卸盖作业", areaBase.Area_Name), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (IDataReader rdrd = DB2Connect.DBHelper.ExecuteReader(_sqlCmdSelectCMDSTATUS))
                {
                    if (rdrd.Read())
                    {
                        CMD_STATUSD = rdrd["CMD_STATUS"].ToString();
                    }
                }
                if (CMD_STATUSD == "EMPTY")
                {

                    string Tran_Name = "";
                    if (areaBase.Area_Name == "1#" || areaBase.Area_Name == "2#" || areaBase.Area_Name == "3#")
                    {
                        Tran_Name = "1";
                        TagDP.SetData("EV_COVER_TASK", string.Format("{0}|1|{1}", areaBase.STOCK_NO, Tran_Name));
                        toolStripMenuItemDown();
                    }
                    else
                    {
                        Tran_Name = "2";
                        TagDP.SetData("EV_COVER_TASK", string.Format("{0}|1|{1}", areaBase.STOCK_NO, Tran_Name));
                        toolStripMenuItemDown();

                    }
                }
                else
                {
                    MessageBox.Show("指令存在，请勿重新下达指令", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
            }
        }
        private void conArea_Load_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 修改盖状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //修改保温坑状态,有无盖，本电脑IP，日期
        private void 有盖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              string sqlm = @"update UACS_YARDMAP_TRAIN_STOCK_DEFINE set STOCK_STATUS='OCCUPY' WHERE AREA_NO=(SELECT AREA_NO FROM  UACS_YARDMAP_AREA_DEFINE WHERE AREA_NAME='" + areaBase.Area_Name + "')";              
               DB2Connect.DBHelper.ExecuteNonQuery(sqlm);

            }
            catch (Exception er)
            {

            }
            //获取当前时间
            string MeText = "有盖" + areaBase.Area_Name;
            string  date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //DateTime date = DateTime.Now;
            //int year = date.Year;
            //int month = date.Month;
            //int day = date.Day;
            //int hours = date.Hour;
            //int Minute = date.Minute;
            //int Second = date.Second;
            //string mm = year + "-" +month+ "-"+day+" "+hours+":"+Minute+":"+Second;    
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
                     string sql = @"insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('" + mIp + "','" + MeText + "','"+date+"')";
                      //  string sqlm = string.Format("insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('{0}','{1}','{2}')",mIp,MeText,date);
                       // string sqlm = @"update UACS_HMI_OPER_HISTORY SET REC_TIME=current timestamp where HOST_IP='" + mIp + "'";
                        DB2Connect.DBHelper.ExecuteNonQuery(sql);
                      //  DB2Connect.DBHelper.ExecuteNonQuery(sqlm);
                    }
                    catch (Exception er)
                    {

                    }
                }
            }
        }

        private void 无盖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EMPTY
            try
            {
                string sqlm = @"update UACS_YARDMAP_TRAIN_STOCK_DEFINE set STOCK_STATUS='EMPTY' WHERE AREA_NO=(SELECT AREA_NO FROM  UACS_YARDMAP_AREA_DEFINE WHERE AREA_NAME='" + areaBase.Area_Name + "')";
                DB2Connect.DBHelper.ExecuteNonQuery(sqlm);

            }
            catch (Exception er)
            {

            }
            //获取当前时间
            string MeText = "无盖" + areaBase.Area_Name;
            string  date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");         
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
                      string sql = @"insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('" + mIp + "','" + MeText + "','"+date+"')";
                        //string sqlm = @"update UACS_HMI_OPER_HISTORY SET REC_TIME=current timestamp where HOST_IP='" + mIp + "'";
                        DB2Connect.DBHelper.ExecuteNonQuery(sql);
                       // DB2Connect.DBHelper.ExecuteNonQuery(sqlm);

                    }
                    catch (Exception er)
                    {
                    }
                }
            }
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
