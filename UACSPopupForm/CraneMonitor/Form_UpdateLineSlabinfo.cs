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
    public partial class Form_UpdateLineSlabinfo : Form
    {
        DataTable dt_Laser = new DataTable();
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
        public Form_UpdateLineSlabinfo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_UpdateLineSlabinfo_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;    
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10F);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10F);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sqlText = @"SELECT A.STOCK_NO,A.MAT_NO_1,A.MAT_NO_2,B.X,B.Y,B.Z FROM UACS_LINE_EXIT_INFO A left join UACS_YARDMAP_TRAIN_STOCK_DEFINE B ON A.STOCK_NO=B.STOCK_NO";           
                //初始化grid
                if (dataGridView1.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    dt_Laser.Load(rdr);
                }
                dataGridView1.DataSource = dt_Laser;       
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }
    }
}
