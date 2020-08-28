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
    public partial class Form_CraneMessage01 : FormBase
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
        DataTable dt_Laser = new DataTable();
        DataTable dtNull = new DataTable();
        ToolTip toolTip1 = new ToolTip();

        CraneL3 crane = new CraneL3();

        public Form_CraneMessage01()
        {
            InitializeComponent();
        }

        private void Form_CraneMessage01_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = SystemColors.Info;
            //  dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10F);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 15F);
            try
            {
                DateTime Getday = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                dateTimeEnd.Value = Getday.AddDays(1);
                dateTimeStart.Value = Getday.AddDays(-1);
                DateTime today = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                DateTime todayAdd = today.AddDays(1);
                string day = today.ToString("yyyy-MM-dd HH:mm:ss");
                string Adday = todayAdd.ToString("yyyy-MM-dd HH:mm:ss");
                string sqlText = @"SELECT STOCK_NO,LAYER_NO,X_ACT,Y_ACT,Z_ACT,MAT_NO_1,MAT_NO_2,REC_TIME,(case when ACTION_STATUS='E' then '吊起'when ACTION_STATUS='S' then '卸下'else ACTION_STATUS end) as ACTION_STATUS,(case when CRANE_MODE='2' then '手动' when CRANE_MODE='4' then '自动' else '未知' end) as CRANE_MODE FROM UACS_YARDMAP_TRACK_OPER";
                sqlText += " where REC_TIME between '{0}'and '{1}' order by REC_TIME desc";
                sqlText = string.Format(sqlText, day, Adday);
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


            }


        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            string datStart = dateTimeStart.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim();
            string datEnd = dateTimeEnd.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim();
            // 查询条件：方坯号
            string Code = TxtCode.Text.Trim();

            if (dateTimeStart.Value < dateTimeEnd.Value || dateTimeStart.Value.Date == dateTimeEnd.Value.Date)
            {
                //if (Code == "" || Code == null)
                //{
                //    try
                //    {
                //        string sqlText = @"SELECT STOCK_NO,LAYER_NO,X_ACT,Y_ACT,Z_ACT,MAT_NO_1,MAT_NO_2,REC_TIME,(case when ACTION_STATUS='S' then '吊起'when ACTION_STATUS='E' then '卸下'else ACTION_STATUS end) as ACTION_STATUS,(case when CRANE_MODE='2' then '手动' when CRANE_MODE='4' then '自动' else '未知' end) as CRANE_MODE FROM UACS_YARDMAP_TRACK_OPER";
                //        sqlText += " where REC_TIME between '{0}'and '{1}'or MAT_NO_1 is null or MAT_NO_2 is null";
                //        sqlText = string.Format(sqlText, datStart, datEnd);
                //        //初始化grid
                //        if (dataGridView1.DataSource != null)
                //        {
                //            dt_Laser.Clear();
                //        }
                //        using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                //        {
                //            dt_Laser.Load(rdr);
                //        }
                //        dataGridView1.DataSource = dt_Laser;

                //    }
                //    catch (Exception er)
                //    {
                //        MessageBox.Show(er.Message + "\r\n" + er.StackTrace);

                //    }
                //}
                //else
                //{

                    try
                    {
                        string sqlText = @"SELECT STOCK_NO,LAYER_NO,X_ACT,Y_ACT,Z_ACT,MAT_NO_1,MAT_NO_2,REC_TIME,(case when ACTION_STATUS='E' then '吊起'when ACTION_STATUS='S' then '卸下'else ACTION_STATUS end) as ACTION_STATUS,(case when CRANE_MODE='2' then '手动' when CRANE_MODE='4' then '自动' else '未知' end) as CRANE_MODE FROM UACS_YARDMAP_TRACK_OPER";
                        sqlText += " where REC_TIME between '{0}'and '{1}'and MAT_NO_1 like '%{2}%'and MAT_NO_2 like '%{3}%'";
                        sqlText = string.Format(sqlText, datStart, datEnd, Code, Code);
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
                //}
            }
            else
            {
                MessageBox.Show("开始时间不能大于结束时间", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            }

        }
    }
}
