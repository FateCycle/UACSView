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
using Excel = Microsoft.Office.Interop.Excel;

namespace UACSView.View_CarneMeage
{
    public partial class Form_CraneJobResultAnalysis : FormBase
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

        public Form_CraneJobResultAnalysis()
        {
            InitializeComponent();
        }

        private void Form_CraneJobResultAnalysis_Load(object sender, EventArgs e)
        {
            dataGridView3.AutoGenerateColumns = false;
        }
        //按年份查询
        private void butYear_Click(object sender, EventArgs e)
        {
            int year1 = dateTimeStart.Value.Year;
            int year2 = dateTimeEnd.Value.Year;
            //获取当前年份
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            // MessageBox.Show("年份"+Year);

            try
            {
               // string sqlster3 = string.Format("select * from mab3 where year(Date)='{0}'", Year);
                string sqlText_Laser = string.Format("SELECT * FROM UACS_YARDMAP_AREA_DEFINE WHERE year(Date)='{0}'", Year);
                //初始化grid
                if (dataGridView3.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                {
                    dt_Laser.Load(rdr);
                }
                dataGridView3.DataSource = dt_Laser;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }
        //查询
        private void butSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (combType.Text.Trim() == "")
                {
                    dt_Laser.Clear();
                    dataGridView3.DataSource = dt_Laser;
                    return;
                }
                //获取查询条件
                string date1 = dateTimeStart.Value.ToString("yyyy-MM-dd").Trim();
                string date2 = dateTimeEnd.Value.ToString("yyyy-MM-dd ").Trim();            
                string Type = combType.Text.Trim();
                //报警信息
                string sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
                sqlText += "WHERE Date between '{0}' and '{1}' or TrueMan like '%{2}%'";
                sqlText = string.Format(sqlText, date1, date2,Type);

                //初始化grid
                if (dataGridView3.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    dt_Laser.Load(rdr);
                }
                dataGridView3.DataSource = dt_Laser;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }


        #region   下拉框绑定数据方法
        private void GetComboxOnParking(ComboBox comBox)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeValue");
            dt.Columns.Add("TypeName");
            //准备数据
            try
            {

                string sqlText = @"SELECT DISTINCT ID as TypeValue,NAME as TypeName FROM UACS_YARDMAP_PARKINGSITE ";
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
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
                comBox.DataSource = dt;
                comBox.DisplayMember = "TypeName";
                comBox.ValueMember = "TypeValue";
                comBox.SelectedItem = 0;
                //comBox.Text = "请选择";
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0},{1}", ex.StackTrace.ToString(), ex.Message.ToString()));
            }
        }
        #endregion
        #region 导出文档
        private void ExportExcels(string fileName, DataGridView gridview)
        {
            try
            {
                string saveFileName = "";

                SaveFileDialog saveDialog = new SaveFileDialog();

                saveDialog.DefaultExt = "xls";

                saveDialog.Filter = "Excel文件|*.xls";

                saveDialog.FileName = fileName;

                saveDialog.ShowDialog();

                saveFileName = saveDialog.FileName;

                if (saveFileName.IndexOf(":") < 0) return; //被点了取消

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {

                    MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");

                    return;

                }

                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
                Excel.Worksheet objSheet = (Excel.Worksheet)workbook.Worksheets.Add(Type.Missing, Type.Missing, 1, Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                Excel.Worksheet objSheet2 = (Excel.Worksheet)workbook.Worksheets.Add(Type.Missing, Type.Missing, 1, Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                worksheet.Name = "自动率";
                objSheet.Name = "行车自动率";
                objSheet2.Name = "行车结果自动率";
                Save2ExcelSheet(gridview, worksheet);
                Save2ExcelSheet(this.dataGridView3, objSheet);
                Save2ExcelSheet(this.dataGridView3, objSheet2);

                if (saveFileName != "")
                {

                    try
                    {

                        workbook.Saved = true;

                        workbook.SaveCopyAs(saveFileName);

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);

                    }

                }
                xlApp.Quit();

                GC.Collect();//强行销毁

                MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 导出数据
        private static void Save2ExcelSheet(DataGridView gridview, Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            try
            {
                //写入标题

                for (int i = 0; i < gridview.ColumnCount; i++)
                {

                    worksheet.Cells[1, i + 1] = gridview.Columns[i].HeaderText;

                }

                //写入数值

                for (int r = 0; r < gridview.Rows.Count; r++)
                {

                    for (int i = 0; i < gridview.ColumnCount; i++)
                    {

                        worksheet.Cells[r + 2, i + 1] = gridview.Rows[r].Cells[i].Value;

                    }

                    System.Windows.Forms.Application.DoEvents();

                }

                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //导出
        private void butIMport_Click(object sender, EventArgs e)
        {
            try
            {
                //string a = "行车作业结果分析.xls"; + startTime + endTime
                string a = "行车作业结果分析";
                ExportExcels(a, dataGridView3);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //按季度查询
        private void butQuarter_Click(object sender, EventArgs e)
        {
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            if (Month == 3 || Month == 4 || Month == 5)
            {

               
                try
                {

                    string sqlText_Laser = string.Format("select * from mab3 where Month(Date) in('{0}','{1}','{2}') and Year(Date)='{3}'", 3, 4, 5, Year);
                    //初始化grid
                    if (dataGridView3.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                    {
                        dt_Laser.Load(rdr);
                    }
                    dataGridView3.DataSource = dt_Laser;
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

                    string sqlText_Laser = string.Format("select * from mab3 where Month(Date) in('{0}','{1}','{2}') and Year(Date)='{3}'", 6, 7, 8, Year);
                    //初始化grid
                    if (dataGridView3.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                    {
                        dt_Laser.Load(rdr);
                    }
                    dataGridView3.DataSource = dt_Laser;
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

                    string sqlText_Laser = string.Format("select * from mab3 where Month(Date) in('{0}','{1}','{2}') and Year(Date)='{3}'", 9, 10, 11, Year);
                    //初始化grid
                    if (dataGridView3.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                    {
                        dt_Laser.Load(rdr);
                    }
                    dataGridView3.DataSource = dt_Laser;
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

                    string sqlText_Laser = string.Format("select * from mab3 where Month(Date) in('{0}','{1}','{2}') and Year(Date)='{3}'", 12, 1, 2, Year);
                    //初始化grid
                    if (dataGridView3.DataSource != null)
                    {
                        dt_Laser.Clear();
                    }
                    using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                    {
                        dt_Laser.Load(rdr);
                    }
                    dataGridView3.DataSource = dt_Laser;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
                }

            }
        }
        //按月度查询
        private void butMonth_Click(object sender, EventArgs e)
        {
            //获取当前月份
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            //  MessageBox.Show("年份" + Month);

           
            try
            {

                string sqlText_Laser = string.Format("select * from mab3 where Month(Date)='{0}'and Year(Date)='{1}' ", Month, Year);
                //初始化grid
                if (dataGridView3.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                {
                    dt_Laser.Load(rdr);
                }
                dataGridView3.DataSource = dt_Laser;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }

        }
        //按周数查询
        private void butWeek_Click(object sender, EventArgs e)
        {
            int Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int day = Convert.ToInt32(DateTime.Now.ToString("dd"));
            var dt = new DateTime(Year, Month, day);
            //找到今年的第一天是周几
            int firstWeekend = Convert.ToInt32(DateTime.Parse(dt.Year + "-1-1").DayOfWeek);

            //获取第一周的差额,如果是周日，则firstWeekend为0，第一周也就是从周天开始的。
            int weekDay = firstWeekend == 0 ? 1 : (7 - firstWeekend + 1);

            //获取今天是一年当中的第几天
            int currentDay = dt.DayOfYear;

            //（今天 减去 第一周周末）/7 等于 距第一周有多少周 再加上第一周的1 就是今天是今年的第几周了
            //    刚好考虑了惟一的特殊情况就是，今天刚好在第一周内，那么距第一周就是0 再加上第一周的1 最后还是1
            int current_week = Convert.ToInt32(Math.Ceiling((currentDay - weekDay) / 7.0)) + 1;
         
            try
            {

                string sqlText_Laser = string.Format("select * from mab3 where CONVERT(VARCHAR(2),DATEPART(WK,date))='{0}'and Year(Date)='{1}' ", current_week, Year);
                //初始化grid
                if (dataGridView3.DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                {
                    dt_Laser.Load(rdr);
                }
                dataGridView3.DataSource = dt_Laser;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
