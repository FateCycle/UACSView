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
using Excel = Microsoft.Office.Interop.Excel;
using Baosight.iSuperframe.Authorization.Interface;

namespace UACSView.View_CarneMeage
{
    public partial class Form_CraneLiftActual : FormBase
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

        public Form_CraneLiftActual()
        {
            InitializeComponent();
        }
        #region   下拉框绑定数据方法
        private void GetComboxOnParking(ComboBox comBox)
        {
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            dt.Columns.Add("TypeValue");
            dt.Columns.Add("TypeName");
            //准备数据
            try
            {
                // 将order的类型统计出来使用distinct去重
                string sqlText = @"SELECT DISTINCT ORDER_TYPE as TypeValue,ORDER_TYPE as TypeName FROM UACS_CRANE_ORDER_L3_OPER";
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText))
                {
                    while (rdr.Read())
                    {                      
                        dr["TypeValue"] = rdr["TypeValue"];
                        dr["TypeName"] = rdr["TypeName"];
                         dt.Rows.Add(dr);
                    }
                }

                //绑定列表下拉框数据        
                comBox.DataSource = dt;
                comBox.DisplayMember = "TypeName";
                comBox.ValueMember = "TypeValue";
                DataTable table = (DataTable)comBox.DataSource;
                // 新增一行,TypeName为0,TypeValue为--请选择--
                DataRow drm = table.NewRow();
                drm[0] = "0";
                drm[1] = "--请选择--";
                table.Rows.InsertAt(drm, 0);
                comBox.DataSource = table; //comboBox1 的数据源为table
                comBox.SelectedIndex = 0;  //默认显示"请选择"

             //   comBox.SelectedItem = 0;
                // comBox.Text = "--请选择--";

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0},{1}", ex.StackTrace.ToString(), ex.Message.ToString()));
            }
        }
        #endregion
        private void Form_CraneLiftActual_Load(object sender, EventArgs e)
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
            //填写指令类型
            GetComboxOnParking(combType);
            // 获得当前日期
            DateTime Getday = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            //默认结束时间为当前时间向后推1天
            dateEnd.Value = Getday.AddDays(1);
            //默认开始时间为当前时间向前推1天
            dateTimeStart.Value = Getday.AddDays(-1);
            //禁止自动生成列
            dataGridView1.AutoGenerateColumns = false;
            DateTime today = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime todayAdd = today.AddDays(1);
            string day = today.ToString("yyyy-MM-dd HH:mm:ss");
            string Adday = todayAdd.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                // 
                // 行车号，吊运模式（行车作业是的模式，1人工、2遥控、4自动、5等待），材料号，库位号，操作时间和X、Y坐标
                string sqlText = @"SELECT ID,MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3_OPER";
                sqlText += " WHERE REC_TIME between '{0}'and '{1}'";
                sqlText = string.Format(sqlText, day, Adday);
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
   
        private void ButSelect_Click(object sender, EventArgs e)
        {
            try
            {            
                //获取查询条件
                string datStart = dateTimeStart.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                string datEnd = dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                if (dateTimeStart.Value < dateEnd.Value || dateTimeStart.Value.Date == dateEnd.Value.Date)
                {
                    try
                    {
                        string Code = txtCode.Text.Trim();
                        //查询条件：方坯号
                        if (Code == "" || Code == null)
                        {
                            Code = "null";
                        }
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
                        //查询条件：指令类型
                        string OrderType = combType.Text.Trim();
                        if(OrderType !=""&&OrderType !=null)
                        {
                            string sqlText = @"SELECT ID,MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3_OPER";
                            sqlText += " WHERE REC_TIME between '{0}'and '{1}' and MAT_NO_1 like '%{2}%' and MAT_NO_2 like '%{3}%'or ORDER_TYPE = '{4}'OR CRANE_GROUP_NO='{5}'";
                            sqlText = string.Format(sqlText, datStart, datEnd, Code, Code, OrderType,CRANE_NOtEXT);
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
                        else
                        {
                            string sqlText = @"SELECT ID,MAT_NO_1,MAT_NO_2,FROM_STOCK_NO,TO_STOCK_NO,CRANE_GROUP_NO,ORDER_TYPE,FROM_LAYER,X,Y,Z,REC_TIME,(case when FLAG='1' then '待作业'when FLAG='2' then '作业中'else '未知' end) as FLAG FROM UACS_CRANE_ORDER_L3_OPER";
                            sqlText += " WHERE REC_TIME between '{0}'and '{1}' and MAT_NO_1 like '%{2}%' and MAT_NO_2 like '%{3}%'OR CRANE_GROUP_NO='{4}'or ORDER_TYPE is null";
                            sqlText = string.Format(sqlText, datStart, datEnd, Code, Code,CRANE_NOtEXT);
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
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("开始时间不能大于结束时间", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }      
        //导出
        private void butImport_Click(object sender, EventArgs e)
        {
            try
            {
                //string a = "行车作业结果分析.xls"; + startTime + endTime
                string a = "吊运实绩";
                ExportExcels(a, dataGridView1);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExportExcels(string fileName, DataGridView gridview)
        {
            try
            {
                string saveFileName = "";
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xls";
              //  saveDialog.Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*","xls","Excel");
                saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //被点了取消

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能您的电脑未安装Excel");
                    return;
                }
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
                worksheet.Name = "吊运实绩";
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

        private static void Save2ExcelSheet(DataGridView gridview, Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            try
            {
                //写入标题

                for (int i = 0; i < gridview.ColumnCount; i++)
                {
                    //if (gridview.Columns[i].Visible)//用作于不导出隐藏列
                    //{
                        worksheet.Cells[1, i + 1] = gridview.Columns[i].HeaderText;
                    //}
                }
               
                //写入数值

                for (int r = 0; r < gridview.Rows.Count; r++)
                {

                    for (int i = 0; i < gridview.ColumnCount; i++)
                    {
                        //if (gridview.Columns[i].Visible)//用作于不导出隐藏列
                        //{
                            worksheet.Cells[r + 2, i + 1] = gridview.Rows[r].Cells[i].Value;
                        //}
                    }

                    System.Windows.Forms.Application.DoEvents();

                }
                
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应

                //列单元格数据格式
                //Excel.Range r1 = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[gridview.Rows.Count + 2, gridview.Columns.Count - 5]);
                //r1.NumberFormat = "0";

                //Excel.Range r2 = worksheet.get_Range(worksheet.Cells[1, gridview.Columns.Count - 5], worksheet.Cells[gridview.Rows.Count + 2, gridview.Columns.Count - 3]);
                //r2.NumberFormat = "yyyy-mm-dd hh:mm:ss";

                //Excel.Range r3 = worksheet.get_Range(worksheet.Cells[1, gridview.Columns.Count - 2], worksheet.Cells[gridview.Rows.Count + 2, gridview.Columns.Count]);
                //r3.NumberFormat = "hh:mm:ss";

                worksheet.Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter; //居中
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
