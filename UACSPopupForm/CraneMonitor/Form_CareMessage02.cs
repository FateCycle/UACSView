using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using System.Reflection;

namespace UACSPopupForm
{
    public partial class Form_CareMessage02 : Form
    { public string FROM_STOCK_NO;
        public string PackOrder;
        // private Baosight.iSuperframe.Authorization.Interface.IAuthorization auth;

        private SaddleBase saddleInfo = new SaddleBase();
        private AreaInfo saddleInfo1 = new AreaInfo();
        DataTable dt_Laser = new DataTable();
        DataTable dt_table = new DataTable();
        private CraneL3 crane = new CraneL3();
        public List<CraneL3> craneList = new List<CraneL3>();
        public AreaInfo SaddleInfo1
        {
            get { return saddleInfo1; }
            set { saddleInfo1 = value; }

        }
        public SaddleBase SaddleInfo
        {
            get { return saddleInfo; }
            set { saddleInfo = value; }
        }
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
                    catch (System.Exception e)
                    {
                        //throw e;
                    }
                }
                return dbHelper;
            }
        }
        #endregion
        public Form_CareMessage02(string PackType)
        {
            InitializeComponent();
            PackOrder = PackType;
        }

        public void st(Button btnValue)
        {
           // dt_Laser.Clear();
            // MessageBox.Show("bb" + nn.Text);
            //  MessageBox.Show("mm" + nn.Name);
            string mText = btnValue.Text.Trim();
            if (mText == "" || mText == "null")
            {
                mText = "underfend";
            }
            try
            {

                //获取查询条件
                //  string ButtonText = button6.Text.Trim();
                //方坯信息
                string sqlText = "select * from UACS_CRANE_ORDER_L3 where 1=1 ";
                sqlText += "AND MAT_NO_1 = '{0}' OR MAT_NO_2 = '{1}'";
                sqlText = string.Format(sqlText, mText, mText);

                //初始化grid
                if (dataGridView1.DataSource != null)
                {
                    dt_table.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    dt_table.Load(rdr);
                }


                dataGridView1.DataSource = dt_table;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
            //foreach (Control ctl in this.Controls)
            //{
            //    if (ctl is Button)
            //    {
            //        Button btn = ctl as Button;
            //       btn.Click += new System.EventHandler(btn_Click);
            //       // Button x = sender as Button;
            //       //   Button btn = (Button)sender;
            //         MessageBox.Show(btn.Name);
            //    }
            //}
        }

        private void Form_CareMessage02_Load(object sender, EventArgs e)
        {

        }
        //button按钮事件
        //    button12.Click += but_click;
        //   button23.Click += xxxx_click;

        //  private void but_click(object sender, EventArgs e)
        //   {
        //      Button x = sender as Button;
        ///      Button btn = (Button)sender;
        //      MessageBox.Show(btn.Name);
        //    }


        private void button23_Click(object sender, EventArgs e)
        {


        }

        #region
        //st(button13);
        //try
        //{
        //    string count;
        //    //获取查询条件
        //    string ButtonText = button6.Text.Trim();
        //    //方坯信息
        //    string sqlText = "select COIL_NO,STEEL_GRANDID,CONTRACT_NO,REC_TIME,UPD_TIME from UACS_YARDMAP_COIL";
        //    //string sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
        //    //sqlText += "WHERE  TrueMan like '%{0}%'";
        //    //sqlText = string.Format(sqlText,ButtonText );

        //    //初始化grid
        //    if (dataGridView1.DataSource != null)
        //    {
        //        dt_Laser.Clear();
        //    }
        //    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
        //    {


        //        count = ManagerHelper.JudgeStrNull(rdr["COIL_NO"]);

        //        dt_Laser.Load(rdr);
        //    }


        //    dataGridView1.DataSource = dt_Laser;
        //}
        //catch (Exception er)
        //{
        //    MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
        //}
        #endregion

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = PackOrder;
            int BtnNum = 6;
            dt_Laser.Clear();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    ctl.Text = "";

                }
            }
         
            if (PackOrder == "第 一 节")
            {
                FROM_STOCK_NO = "P1";
            }
            if (PackOrder == "第 二 节")
            {
                FROM_STOCK_NO = "P2";
            }
            if (PackOrder == "第 三 节")
            {
                FROM_STOCK_NO = "P3";
            }
            //   MessageBox.Show(FROM_STOCK_NO);
            //  string Text = saddleInfo.Mat_No;
            //  string Text1 = saddleInfo1.COIL_NO;
            //  button23.Text = Text;

            try
            {
                DataTable table = new DataTable();
                //方坯信息
                string sqlText = "select MAT_NO_1,MAT_NO_2 from UACS_CRANE_ORDER_L3 where 1=1 ";
                //string sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
                sqlText += "AND FROM_STOCK_NO ='{0}'";
                sqlText = string.Format(sqlText, FROM_STOCK_NO);

                //初始化grid
                if (dataGridView1.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    // 
                    //   theArea.AreaType = Convert.ToInt32(rdr["AREA_TYPE"]);
                    //   DataRow dr = dt_Laser.NewRow();
                    // mm  =rdr["MAT_NO_1"].ToString();
                    //   dr["MAT_NO_1"] = rdr["MAT_NO_1"];

                    // string count = ManagerHelper.JudgeStrNull(rdr["COIL_NO"]);

                    dt_Laser.Load(rdr);
                    
                    //        int ss =Convert.ToInt32( dt_Laser.Rows);
                    foreach (DataRow item in dt_Laser.Rows)
                    {
                        //  List<string> n1 = new List<string>();
                        string MANT1 = ManagerHelper.JudgeStrNull(item["MAT_NO_1"]);
                        string MANT2 = ManagerHelper.JudgeStrNull(item["MAT_NO_2"]);
                      //  MessageBox.Show("mm" + n1);
                        string btnContor = "button";

                        string btnCon = btnContor + BtnNum;

                        int Numsum = BtnNum + 1;
                        string btnCon2 = btnContor + Numsum;
                        Button button = new Button();
                        Button control = (Button)Controls.Find(btnCon, true)[0];
                        Button control2= (Button)Controls.Find(btnCon2, true)[0];
                        int Dt_Count = dt_Laser.Rows.Count;
                        control.Text = MANT1;
                        control2.Text = MANT2;
                        BtnNum = BtnNum + 2;
                        //string mmm = n1.Substring(2, 3);
                        //if (mmm == "403")
                        //{
                        //    button12.Text = n1;


                        //}
                        //if (mmm == "406")
                        //{


                        //    button15.Text = n1;
                        //}
                        if (BtnNum > 25)
                        {
                            break ;

                        }

                        if (MANT2 != "" && MANT2 != null)
                        {
                            string ttt = MANT2.Substring(2, 3);

                        }

                        //   string mmm = n1.Substring(3,1);
                        //   string ttt = n2.Substring(3,4);

                        //   button13.Text = mmm;
                        //   MessageBox.Show(n1);

                        // int  mmm1 = int .Parse (mmm);
                        //   int ttt1 = int .Parse (ttt);
                        //if (mmm == "1" && ttt == "2")
                        //{
                        //    button13.Text = n1;

                        //}
                        //else
                        //{
                        //    MessageBox.Show("nn" + n1);
                        //}
                    }
                }
                //    dataGridView1.DataSource = dt_Laser;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            st(button6);
           // dt_Laser.Clear();
            // MessageBox.Show("bb" + nn.Text);
            //  MessageBox.Show("mm" + nn.Name);
          
        }
    }

 
}
