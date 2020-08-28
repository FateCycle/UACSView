using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baosight.iSuperframe.Forms;
using System.Reflection;
using UACSDAL;
using UACSControls;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;

namespace UACSView.View_CarneMeage
{
    public partial class Form_CraneMessage03:FormBase
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

        CraneL3 crane = new CraneL3();
        public Form_CraneMessage03()
        {
            InitializeComponent();
        }

        private void Form_CraneMessage03_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            try
            {
                string sqlText = @"SELECT * FROM UACS_LASER_LINE_EXIT_STATUS";
                //     sqlText += "AND REC_TIME like '%{0}%'";
                //   sqlText = string.Format(sqlText,NowDate);
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
