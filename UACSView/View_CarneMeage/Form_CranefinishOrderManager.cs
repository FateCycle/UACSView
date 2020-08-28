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
    public partial class Form_CranefinishOrderManager : FormBase
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

        public Form_CranefinishOrderManager()
        {
            InitializeComponent();
        }

        private void PalTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_CranefinishOrderManager_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

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


                worksheet.Name = "行车指令完成管理";
                Save2ExcelSheet(gridview, worksheet);

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

                MessageBox.Show("文件导出保存成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                //列单元格数据格式
                //  Excel.Range r1 = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[gridview.Rows.Count + 2, gridview.Columns.Count - 5]);
                //   r1.NumberFormat = "0";

                //   Excel.Range r2 = worksheet.get_Range(worksheet.Cells[1, gridview.Columns.Count - 5], worksheet.Cells[gridview.Rows.Count + 2, gridview.Columns.Count - 3]);
                //   r2.NumberFormat = "yyyy-mm-dd hh:mm:ss";

                //   Excel.Range r3 = worksheet.get_Range(worksheet.Cells[1, gridview.Columns.Count - 2], worksheet.Cells[gridview.Rows.Count + 2, gridview.Columns.Count]);
                //    r3.NumberFormat = "hh:mm:ss";

                worksheet.Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter; //居中
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        //导出
        private void butImport_Click(object sender, EventArgs e)
        {
            try
            {
                //string a = "行车作业结果分析.xls"; + startTime + endTime
                string a = "行车完成指令管理";
                ExportExcels(a, dataGridView1);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        //条件查询数据
        private void butSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text.Trim() == "" && combType.Text.Trim() == "")
                {
                    dt_Laser.Clear();
                    dataGridView1.DataSource = dt_Laser;
                    return;
                }
                //获取查询条件
                string date1 = dateTimeStart.Value.ToString("yyyy-MM-dd").Trim();
                string date2 = dateTimeEnd.Value.ToString("yyyy-MM-dd").Trim();
                string Code = txtCode.Text.Trim();
                string TrueType = combType.Text.Trim();
                
                string sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
                sqlText += "WHERE Date between '{0}' and '{1}' or TrueMan like '%{2}%' or Module like '%{3}%'";
                sqlText = string.Format(sqlText, date1, date2, Code, TrueType);

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
