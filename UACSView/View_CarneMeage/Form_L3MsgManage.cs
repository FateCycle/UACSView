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
using System.Globalization;

namespace UACSView.View_CarneMeage
{
    public partial class Form_L3MsgManage : FormBase
    {

        IAuthorization auth = Baosight.iSuperframe.Common.FrameContext.Instance.GetPlugin<Baosight.iSuperframe.Authorization.Interface.IAuthorization>()
as Baosight.iSuperframe.Authorization.Interface.IAuthorization;


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
        public Form_L3MsgManage()
        {
            InitializeComponent();
        }

        #region   下拉框绑定数据方法
        private void GetComboxOnParking(ComboBox combex)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeValue");
            dt.Columns.Add("TypeName");
            //准备数据
            try
            {

                string sqlText = @"SELECT distinct ORDER_TYPE as TypeValue,ORDER_TYPE as TypeName FROM UACS_CRANE_ORDER_L3 ";
                using (IDataReader rdr =DBHelper.ExecuteReader(sqlText))
                {
                    while (rdr.Read())
                    {
                        DataRow dr = dt.NewRow();

                        dr["TypeValue"] = rdr["TypeValue"];
                        dr["TypeName"] = rdr["TypeName"];
                       
                        dt.Rows.Add(dr);
                    }
                }

                //绑定列表下拉框数据
                combex.DataSource = dt;
                combex.DisplayMember = "TypeName";
                combex.ValueMember = "TypeValue";
                DataTable table = (DataTable)combex.DataSource;
                DataRow drm = table.NewRow();
                drm[0] = "0";
                drm[1] = "--请选择--";
                table.Rows.InsertAt(drm, 0);
                combex.DataSource = table; //comboBox1 的数据源为table
                combex.SelectedIndex = 0;  //默认显示"请选择"
                //combex.SelectedItem = 0;
                //combex.Text = "请选择";

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0},{1}", ex.StackTrace.ToString(), ex.Message.ToString()));
            }
        }
        #endregion
     
        private void Form_L3MsgManage_Load(object sender, EventArgs e)
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


            //绑定下拉框数据
            GetComboxOnParking(combType);
            dataGridView1.AutoGenerateColumns = false;
            DateTime today = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            dateTimePicker2.Value = today.AddDays(1);
            dateTimePicker1.Value = today.AddDays(-1);
          DateTime todayAdd = today.AddDays(1);
            string day = today.ToString("yyyy-MM-dd HH:mm:ss");
            string Adday = todayAdd.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                string sqlText = @"SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 WHERE 1=1 ";
                sqlText += "AND REC_TIME between '{0}'and '{1}' order by REC_TIME desc";
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
                dataGridView1.ClearSelection();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
            //页面初始化数据加载
            // #region
            // string NowDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            // try
            // {
            //     string sqlText = @"SELECT * FROM UACS_CRANE_ORDER_L3 ";
            ////     sqlText += "AND REC_TIME like '%{0}%'";
            //  //   sqlText = string.Format(sqlText,NowDate);
            //     //初始化grid
            //     if (dataGridView1.DataSource != null)
            //     {
            //         dt_Laser.Clear();
            //     }
            //     using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
            //     {
            //         dt_Laser.Load(rdr);
            //     }
            //     dataGridView1.DataSource = dt_Laser;


            // }
            // catch (Exception er)
            // {
            //     MessageBox.Show(er.Message + "\r\n" + er.StackTrace);

            // }

            // #endregion

            //页面数据报警提示
            #region 
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string d = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string s = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string getval = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    //  MessageBox.Show(s);
                    if (s == "" || s == null)
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Magenta;
                        this.dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed;

                    }
                    if (d == "" || d == null)
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Magenta;
                        this.dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.OrangeRed;
                    }
                    if (getval == "作业中")
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                }

            }

            #endregion
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //查询
        private void ButSelect_Click(object sender, EventArgs e)
        {


            string m1 = dateTimePicker1.Value.ToString("yyyy-MM-dd").Trim();
            string t1 = dateTimePicker2.Value.ToString("yyyy-MM-dd").Trim();

            string m2 = dateTimeStart.Value.ToString("HH:mm:ss").Trim();
            string DateStart = m1 + " " + m2;

            string t2 = dateTimeStart1.Value.ToString("HH:mm:ss").Trim();
            string DateStart1 = t1 + " " + t2;


            // string Datetart = dateTimeStart.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim ();
            //    string DateStart1 = dateTimeStart1.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim ();
            // string DateEnd = dateTimeEnd.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //   MessageBox.Show(DateStart);
            string TexCode = txtCode.Text.Trim();
            string TexType = combType.Text.Trim();
            // 查询条件：指令号
            string CRANE_NOtEXT = "";
            if (CRANE_NO.Text.Trim().Length > 1)
            {
                CRANE_NOtEXT = CRANE_NO.Text.Trim();
            }
            else
            {
                CRANE_NO.Text = "";
            }
            //     string X = textX.Text.Trim();
            //  string Y = textY.Text.Trim();
            //   string Z = textZ.Text.Trim();
            if (dateTimePicker1.Value < dateTimePicker2.Value || dateTimePicker1.Value.Date == dateTimePicker2.Value.Date)
            {
                try
                {
                    //获取查询条件     

                    if (TexCode == null || TexCode == "")
                    {
                        TexCode = "null";
                    }
                    if (TexType == null || TexType == "")
                    {
                        string sqlText = @"SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 WHERE 1=1 ";
                        sqlText += "AND REC_TIME between '{0}'and '{1}' and MAT_NO_1 like '%{2}%' OR ORDER_TYPE is null and MAT_NO_2 like '%{3}%'OR CRANE_GROUP_NO='{4}'";

                        sqlText = string.Format(sqlText, DateStart, DateStart1, TexCode, TexCode,CRANE_NOtEXT);
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
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        string sqlText = @"SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 WHERE 1=1 ";
                        sqlText += "AND REC_TIME between '{0}'and '{1}' and MAT_NO_1 like '%{2}%' OR ORDER_TYPE = '{3}' and MAT_NO_2 like '%{4}%'OR CRANE_GROUP_NO='{5}'";
                        sqlText = string.Format(sqlText, DateStart, DateStart1, TexCode, TexType, TexCode,CRANE_NOtEXT);
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
                        dataGridView1.ClearSelection();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
                }


            }
            else
            {
                MessageBox.Show("开始时间不能大于结束时间", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }



        }

        private void combType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //年
        private void butYear_Click(object sender, EventArgs e)
        {
          //  int year1 = dateTimeStart.Value.Year;
          //  int year2 = dateTimeEnd.Value.Year;
            //获取当前年份
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            // MessageBox.Show("年份"+Year);

            try
            {
                // string sqlster3 = string.Format("select * from mab3 where year(Date)='{0}'", Year);
                string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 WHERE year(REC_TIME)='{0}'", Year);
                //初始化grid
                if (dataGridView1.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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
        //季度
        private void butQuarter_Click(object sender, EventArgs e)
        {
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            if (Month == 3 || Month == 4 || Month == 5)
            {
                try
                {

                    string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 where Month(REC_TIME) in('{0}','{1}','{2}') and Year(REC_TIME)='{3}'", 3, 4, 5, Year);
                    //初始化grid
                    if (dataGridView1.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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
            if (Month == 6 || Month == 7 || Month == 8)
            {


                try
                {

                    string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 where Month(REC_TIME) in('{0}','{1}','{2}') and Year(REC_TIME)='{3}'", 6, 7, 8, Year);
                    //初始化grid
                    if (dataGridView1.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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
            if (Month == 9 || Month == 10 || Month == 11)
            {


                try
                {

                    string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 where Month(REC_TIME) in('{0}','{1}','{2}') and Year(REC_TIME)='{3}'", 9, 10, 11, Year);
                    //初始化grid
                    if (dataGridView1.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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
            if (Month == 12 || Month == 1 || Month == 2)
            {


                try
                {

                    string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 where Month(REC_TIME) in('{0}','{1}','{2}') and Year(REC_TIME)='{3}'", 12, 1, 2, Year);
                    //初始化grid
                    if (dataGridView1.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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
        //月
        private void butMonth_Click(object sender, EventArgs e)
        {
            //获取当前月份
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            //  MessageBox.Show("年份" + Month);
            try
            {

                string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 where Month(REC_TIME)='{0}'and Year(REC_TIME)='{1}' ", Month, Year);
                //初始化grid
                if (dataGridView1.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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
        //周
        private void butWeek_Click(object sender, EventArgs e)
        {
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int day = Convert.ToInt32(DateTime.Now.ToString("dd"));
            var dt = new DateTime(Year, Month, day);
            //找到今年的第一天是周几
            // 年份-1-1拼接成字符串
            int firstWeekend = Convert.ToInt32(DateTime.Parse(dt.Year + "-1-1").DayOfWeek);

            //获取第一周的差额,如果是周日，则firstWeekend为0，第一周也就是从周天开始的。
            // 第一周还有多少天
            int weekDay = firstWeekend == 0 ? 1 : (7 - firstWeekend + 1);

            //获取今天是一年当中的第几天
            int currentDay = dt.DayOfYear;

            //（今天 减去 第一周周末）/7 等于 距第一周有多少周 再加上第一周的1 就是今天是今年的第几周了
            //    刚好考虑了惟一的特殊情况就是，今天刚好在第一周内，那么距第一周就是0 再加上第一周的1 最后还是1
            int current_week = Convert.ToInt32(Math.Ceiling((currentDay - weekDay) / 7.0)) + 1;
            //GregorianCalendar gc = new GregorianCalendar();
            //int mm = gc.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            try
            {

                // string sqlText_Laser = string.Format("select * from UACS_CRANE_ORDER_L3 where REC_TIME between '{0}'and '{1}' ",DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString ("yyyy-MM-dd HH:mm:ss"));
                string sqlText_Laser = string.Format("SELECT MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3 where WEEK(REC_TIME)='{0}'and Year(REC_TIME)='{1}' ", current_week, Year);
                //初始化grid
                if (dataGridView1.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
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

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //页面数据报警提示
            #region 
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string d = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string s = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string getval = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    //  MessageBox.Show(s);


                    // 必须有方坯号，不然报警
                    if (s == "" || s == null || d == "" || d == null)
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Magenta;
                        this.dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.OrangeRed;

                    }
                    if (d == "" || d == null)
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Magenta;
                        this.dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.OrangeRed;
                    }
                    if (getval == "作业中")
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                }

            }
            #endregion



        }

        private void CRANE_NO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
