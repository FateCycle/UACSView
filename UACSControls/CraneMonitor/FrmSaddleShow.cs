using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;
using UACSDAL.Common;
using System.Reflection;
using UACSControls;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;



namespace UACSControls
{
    public partial class FrmSaddleShow : Form
    {
        public FrmSaddleShow()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.Load += FrmSaddleShow_Load;
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
                        dbHelper = Baosight.iSuperframe.Common.DataBase.DBFactory.GetHelper("ZJ2250");//平台连接数据库的Text
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
        DataTable dt_Laser = new DataTable();
        DataTable dtNull = new DataTable();
        ToolTip toolTip1 = new ToolTip();
        string carHearDrection = "";
        private AreaBase areaBase = new AreaBase();
        public AreaBase AreaBase
        {
            get { return areaBase; }
            set { areaBase = value; }
        }
        conStockSaddleModel stockSaddleModel = null;

        void FrmSaddleShow_Load(object sender, EventArgs e)
        {
            //窗体固定大小
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;

            lblArea.Text = areaBase.Area_Name + "库位详细信息";

            stockSaddleModel = new conStockSaddleModel();

            stockSaddleModel.conInit(panel2, areaBase, constData.tagServiceName, panel2.Width, panel2.Height, constData.xAxisRight, constData.yAxisDown,constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY);
        }
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdata_Click(object sender, EventArgs e)
        {
            stockSaddleModel.conInit(panel2, areaBase, constData.tagServiceName, panel2.Width, panel2.Height, constData.xAxisRight, constData.yAxisDown,constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblArea_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FrmSaddleShow_Load_1(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            try
            {
                string sqlText = "SELECT * FROM UACS_YARDMAP_AREA_DEFINE where 1=1 ";
                //string sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
                sqlText += "AND  AREA_NAME='{0}'";
                sqlText = string.Format(sqlText, areaBase.Area_Name);
                if (dataGridView1.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    dt_Laser.Load(rdr);
                }
                dataGridView1.DataSource = dt_Laser;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        string s = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        //  MessageBox.Show(s);
                        if (s == "" || s == null)
                        {
                            this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            //  this.dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed;

                        }
                        else
                        {


                        }
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
