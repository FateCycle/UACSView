using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL.CraneMonitor;
using UACSDAL.Common;
using System.Xml.Schema;

namespace UACSPopupForm
{
    public partial class PopAlarmCurrent : Form
    {
        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDataProvider = new Baosight.iSuperframe.TagService.Controls.TagDataProvider();

        Baosight.iSuperframe.TagService.DataCollection<object> inDatas = new Baosight.iSuperframe.TagService.DataCollection<object>();

        private string[] arrTagAdress;

        private string crane_No = null;

        private string TagName = null;

        //  报警代码和注释
        IList<TCraneAlarm> listCraneAlarm = new List<TCraneAlarm>();

        /// <summary>
        /// 存解析出来的报警代码
        /// </summary>
        private List<int> listAlarm = new List<int>();
        /// <summary>
        /// 行车号
        /// </summary>
        public string Crane_No
        {
            get { return crane_No; }
            set
            {
                crane_No = value;
            }
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        private static Baosight.iSuperframe.Common.IDBHelper dbHelper = null;

        private static Baosight.iSuperframe.Common.IDBHelper DBHelper
        {
            get
            {
                if (dbHelper == null)
                {
                    try
                    {
                        dbHelper = Baosight.iSuperframe.Common.DataBase.DBFactory.GetHelper("localAPP");
                    }
                    catch (System.Exception e)
                    {
                        //throw e;
                    }

                }
                return dbHelper;
            }
        }

        public void InitTagDataProvide(string tagServiceName)
        {
            try
            {
                tagDataProvider.ServiceName = tagServiceName;
            }
            catch (Exception ex)
            {
            }
        }
        
        public PopAlarmCurrent()
        {
            InitializeComponent();
            this.Load += PopAlarmCurrent_Load;
        }

        void PopAlarmCurrent_Load(object sender, EventArgs e)
        {
            if (Crane_No != null)
            {
                tagDataProvider.ServiceName = "iplature";
                TagName = Crane_No + "_ALARM_CURRENT";
                lblCraneNo.Text = Crane_No + " 报警";
                SetReady(TagName);
                readTags();

                string value = get_value_string(TagName);


                string[] sArray = value.Split(',');
                listAlarm.Clear();
                foreach (string i in sArray)
                {
                    string dd = i;
                    if (dd == " " || dd == null || dd == "" || dd == "undefined")
                    {
                        dd = "0";

                    }
                    int values = Convert.ToInt32(dd.ToString());
                    listAlarm.Add(values);
                }

                DataTable dt = GetDgvMessage(listAlarm);
                
                listCraneAlarm = Common.BindingDaTable2Entitys<TCraneAlarm>(dt);

                //  获取查询的代码
                List<int> listCraneAlarmCode = listCraneAlarm.Select(x => x.ALARM_CODE).ToList();


                if (listCraneAlarm.Count < 1)
                {

                    //  如果都是0说明电控正常
                    if(listAlarm.All(x=>x== 0))
                    {
                        listView1.BeginUpdate();
                        ListViewItem listview = new ListViewItem();
                        listview.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
                        listview.Text = string.Format("{0}电控", crane_No);
                        listview.SubItems.Add("0");
                        listview.SubItems.Add("行车电控正常！");
                        listview.ForeColor = Color.SteelBlue;
                        listView1.Items.Add(listview);
                        listView1.EndUpdate();
                    }
                    //  说明有未知代码
                    else
                    {
                        listView1.BeginUpdate();
                        foreach(int alarmplccode in listAlarm)
                        {
                            //  挑出未知代码
                            if(alarmplccode!=0)
                            {
                                ListViewItem listview = new ListViewItem();
                                listview.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
                                listview.Text = string.Format("{0}电控", crane_No);
                                listview.SubItems.Add(alarmplccode.ToString());
                                listview.SubItems.Add("未知代码？");
                                listview.ForeColor = Color.Brown;
                                listView1.Items.Add(listview);

                            }
                        }
                        listView1.EndUpdate();

                    }

                }

                //  有实实在在的报警信息
                else
                {
                    foreach(int code in listAlarm)
                    {
                        if (code == 0) continue;

                        // 获取对应代码在查到的list中的下标
                        int index = listCraneAlarmCode.FindIndex(x => x == code);
                        ListViewItem listview = new ListViewItem();
                        listview.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
                        listview.ForeColor = Color.Brown;
                        listview.Text = string.Format("{0}电控", crane_No);
                        //对应代码在数据库中有值
                        if (index>=0)
                        {
                           
                            listview.SubItems.Add(listCraneAlarm[index].ALARM_CODE.ToString());
                            listview.SubItems.Add(listCraneAlarm[index].ALARM_INFO);
                        }
                        // 对应代码在数据库中没有值
                        else
                        {
                            listview.SubItems.Add(code.ToString());
                            listview.SubItems.Add("未知代码");
                        }
                        listview.ForeColor = Color.Brown;
                        listView1.Items.Add(listview);
                    }

                    

                }

                //List<int> ids = DataTablePro.GetColumnValues<int>(dt, "ID");

            }

        }


        private DataTable GetDgvMessage(List<int> list)
        {
            DataTable dt = new DataTable();
            bool hasSetColumn = false;


            try
            {
                string sql = @"SELECT * FROM UACS_CRANE_ALARM_CODE_DEFINE ";
                sql += " WHERE ALARM_CODE IN (";
                foreach (int item in list)
                {
                    sql += "" + item + ",";
                }
                sql = sql.Substring(0, sql.Length - 1);
                sql += ");";
                using (IDataReader rdr = DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            if (!hasSetColumn)
                            {
                                if(i == 0) dt.Columns.Add("CRANE_NO", typeof(String));
                                else
                                {
                                    DataColumn dc = new DataColumn();
                                    dc.ColumnName = rdr.GetName(i-1);
                                    dt.Columns.Add(dc);
                                }
;
                            }

                            dr[i] = rdr[i];
                        }

                        hasSetColumn = true;
                        dt.Rows.Add(dr);
                    }
                }
                if (hasSetColumn == false)
                {
                    dt.Columns.Add("CRANE_NO", typeof(String));
                    dt.Columns.Add("ALARM_CODE", typeof(String));
                    dt.Columns.Add("ALARM_INFO", typeof(String));
                }

            }
            catch (Exception er)
            {

            }

            return dt;
        }


        #region read tag

        public void SetReady(string tagName)
        {
            try
            {
                List<string> lstAdress = new List<string>();
                lstAdress.Add(tagName);
                arrTagAdress = lstAdress.ToArray<string>();
            }
            catch (Exception er)
            {

            }
        }

        private void readTags()
        {
            try
            {
                inDatas.Clear();
                tagDataProvider.GetData(arrTagAdress, out inDatas);
            }
            catch (Exception ex)
            {
            }
        }

        private string get_value_string(string tagName)
        {
            string theValue = string.Empty;
            object valueObject = null;
            try
            {
                valueObject = inDatas[tagName];
                theValue = Convert.ToString((valueObject));
            }
            catch
            {
                valueObject = null;
            }
            return theValue; ;
        }
        #endregion

        private void PopAlarmCurrent_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
