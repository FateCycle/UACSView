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
    public partial class UserWinForm : FormBase
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
        string carHearDrection = "";


  
        public UserWinForm()
        {
            InitializeComponent();


            Type dgvEntrySaddleType = this.dataGridView1.GetType();
            PropertyInfo pi = dgvEntrySaddleType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridView1, true, null);
        }

        private UnitEntrySaddleInfo exitSaddleInfo = new UnitEntrySaddleInfo();
        private DataTable InitDataTable(DataGridView datagridView)
        {
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn dgvColumn in datagridView.Columns)
            {
                DataColumn dtColumn = new DataColumn();
                if (!dgvColumn.GetType().Equals(typeof(DataGridViewCheckBoxColumn)))
                {
                    dtColumn.ColumnName = dgvColumn.Name.ToUpper();
                    dtColumn.DataType = typeof(String);
                    dataTable.Columns.Add(dtColumn);
                }
                else
                {
                    dtColumn.ColumnName = dgvColumn.Name.ToUpper();
                    //dtColumn.DataType = typeof(bool);
                    dataTable.Columns.Add(dtColumn);
                }
            }
            return dataTable;
        }
        public void getEntrySaddleDt1(DataGridView _dgv)
        {
            string sqlster = string.Format("SELECT COIL_NO,STEEL_GRANDID,CONTRACT_NO,REC_TIME,UPD_TIME FROM UACS_YARDMAP_COIL");
            using (IDataReader rdr =DB2Connect.DBHelper.ExecuteReader(sqlster))
            {
                while (rdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["COIL_NO"] = rdr["COIL_NO"];
                    dr["STEEL_GRANDID"] = rdr["STEEL_GRANDID"];
                    dr["CONTRACT_NO"] = rdr["CONTRACT_NO"];
                    dr["REC_TIME"] = rdr["REC_TIME"];
                    dr["UPD_TIME"] = rdr["UPD_TIME"];
                    dt.Rows.Add(dr);
                }
            }
        }

        private void GetComboxOnParking(DataGridView comBox)
        {

            string mm;
            string  dd = "29247141601";
            string NowDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DataTable dt = new DataTable();
            dt.Columns.Add("COIL_NO");
            dt.Columns.Add("STEEL_GRANDID");
            dt.Columns.Add("CONTRACT_NO");
            dt.Columns.Add("REC_TIME");
            dt.Columns.Add("UPD_TIME");
            //准备数据
            try
            {
                // string sqlText = string.Format("SELECT * FROM UACS_YARDMAP_COIL WHERE ROWNUM <= 300");
                string sqlText = string.Format("select COIL_NO,STEEL_GRANDID,CONTRACT_NO,REC_TIME,UPD_TIME from UACS_YARDMAP_COIL where REC_TIME like '%{0}%'OR COIL_NO='{1}' ", NowDate,textBox1 .Text .Trim ());
                //string sqlText = @"SELECT DISTINCT ID as TypeValue,NAME as TypeName FROM UACS_YARDMAP_PARKINGSITE ";
                using (IDataReader rdr =DB2Connect.DBHelper.ExecuteReader(sqlText))
                {
                    while (rdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["COIL_NO"] = rdr["COIL_NO"];
                        dr["STEEL_GRANDID"] = rdr["STEEL_GRANDID"];
                        dr["CONTRACT_NO"] = rdr["CONTRACT_NO"];
                        dr["REC_TIME"] = rdr["REC_TIME"];
                        dr["UPD_TIME"] = rdr["UPD_TIME"];
                        mm = rdr["COIL_NO"].ToString ();
                        foreach (int ss in mm)
                        {
                           int  bb = int.Parse(dd);
                            if(ss==bb)
                            {
                                label3.Text = ss.ToString();

                            }

                        }

                        dt.Rows.Add(dr);
                    }
                }
                //绑定dateGridView数据
                comBox.DataSource = dt;
              //  comBox.DisplayMember = "TypeName";
              //  comBox.ValueMember = "TypeValue";
             //   comBox.SelectedItem = 0;
                //comBox.Text = "请选择";
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0},{1}", ex.StackTrace.ToString(), ex.Message.ToString()));
            }
        }
        private void UserWinForm_Load(object sender, EventArgs e)
        {

            dateTimeStart.Value = DateTime.Now;
            dateTimeEnd.Value  = DateTime.Now;
            dataGridView1.AutoGenerateColumns = false;

            // exitSaddleInfo.getEntrySaddleDt1(dataGridView1);
            // getEntrySaddleDt1(dataGridView1);
            GetComboxOnParking(dataGridView1);

                //try
                //{
                //    //出库激光扫描信息
                //    string sqlster = string.Format("SELECT * FROM UACS_YARDMAP_COIL");


            //    //初始化grid
            //    if (dataGridView1.DataSource != null)
            //    {
            //        dt_Laser.Clear();
            //    }
            //    using (IDataReader rdr = DBHelper.ExecuteReader(sqlster))
            //    {
            //        dt_Laser.Load(rdr);
            //    }
            //    dataGridView1.DataSource = dt_Laser;
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            //}

            //计算
            int count = 0;
            try
            {
               //c string sqlText = " SELECT COUNT (*) COUNT FROM  UACS_TRUCK_STOWAGE_DETAIL WHERE STOWAGE_ID ='" + stowageID + "'   AND STATUS IN(0,30)";
                string sqlText = " SELECT COUNT (*) COUNT FROM  UACS_YARDMAP_COIL";

                using (IDataReader rdr =DB2Connect.DBHelper.ExecuteReader(sqlText))
                {
                    if (rdr.Read())
                    {
                        count = ManagerHelper.JudgeIntNull(rdr["COUNT"]);
                        label2.Text = count.ToString ();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0},{1}", ex.StackTrace.ToString(), ex.Message.ToString()));
            }
          
            //  string sqlster = string.Format("SELECT * FROM UACS_YARDMAP_AREA_DEFINE");
            //  DataTable dtResult = InitDataTable(dataGridView1);
            //  using (IDataReader rdr = DBHelper.ExecuteReader(sqlster))
            //  {
            //      bool hasSetColumn = false;
            //      while (rdr.Read())
            //      {
            //          if (!hasSetColumn)
            //          {
            //              setDataColumn(dtResult, rdr);
            //          }
            //          hasSetColumn = true;
            //          DataRow dr = dtResult.NewRow();
            //          for (int i = 0; i < rdr.FieldCount; i++)
            //          {
            //              dr[i] = rdr[i];
            //          }
            //          dtResult.Rows.Add(dr);
            //      }
            //  }
            //  DataTable dataTable1 =dtResult ;
            //this.dataGridView1.DataSource = dataTable1;

            //dataGridView1.DataSource = dataTable1;
        }
        private void setDataColumn(DataTable dt, IDataReader rdr)
        {
            for (int i = 0; i < rdr.FieldCount; i++)
            {
                DataColumn dc = new DataColumn();
                dc.ColumnName = rdr.GetName(i);
                dt.Columns.Add(dc);
            }
        }

        private DataTable BindMatStock()
        {
            DataTable dtResult = InitDataTable(dataGridView1);
            DataTable dtPick = new DataTable();
            string sqlster = string.Format("SELECT * FROM UACS_YARDMAP_AREA_DEFINE");
           

            // 查询语句
            using (IDataReader rdr =DB2Connect.DBHelper.ExecuteReader(sqlster))
            {
                bool hasSetColumn = false;
                while (rdr.Read())
                {
                    if (!hasSetColumn)
                    {
                        setDataColumn(dtResult, rdr);
                    }
                    hasSetColumn = true;
                    DataRow dr = dtResult.NewRow();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        dr[i] = rdr[i];
                    }
                    dtResult.Rows.Add(dr);
                }
            }

            return dtResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dictionary<string, LASER_OUT_DATA> dictGrooveIDLaserOut = new Dictionary<string, LASER_OUT_DATA>();
            //sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
            //sqlText += "WHERE TREATMENT_NO = '{0}' AND LASER_ACTION_COUNT = '{1}'";
            //sqlText = string.Format(sqlText, treatmentNo, LASER_ACTION_COUNT);
            //Format("LOT_NO like '%{0}%'", strLotNo);

            //sqlText_All = string.Format("{0} WHERE PLAN_NO IN ({1})", sqlText_All, subSql);

            //string mm;
            //long dd = 29247141601;
            try
            {
                //if (textBox1.Text.Trim () == "")
                //{
                //    dt_Laser.Clear();
                //    dataGridView1.DataSource = dt_Laser;
                //    return;
                //}
                string Text1 = textBox1.Text.Trim();
                //if (Text1 == null || Text1 =="")
                //{
                //    Text1 = "undefined";

                //}
                //string Text2 = dateTimeStart.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim();
                //string Text3 = dateTimeEnd.Value.ToString("yyyy-MM-dd HH:mm:ss").Trim();

                //if (Text2 == null || Text2 == "")
                //{
                //    Text2 = "undefined";
                //}
                //if(Text3 ==null || Text3 =="")
                //{
                //    Text3 = "undefined";
                //}
                //if(Convert.ToDateTime(Text2)>Convert.ToDateTime (Text3))
                //{
                //    MessageBox.Show("指令开始时间不能大于结束时间！","系统提示：",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //}
                //出库激光扫描信息
                //   between '{0}' and '{1}' or TrueMan = '{2}'or MAT_NO = '{3}'"
                string sqlText_Laser = @"SELECT * FROM UACS_YARDMAP_COIL WHERE COIL_NO = '"+ Text1 + "' ";
              //  sqlText_Laser += "AND COIL_NO like '%{0}%' OR REC_TIME between '{1}' and '{2}' ";
               
               // sqlText_Laser += "AND COIL_NO like '%{0}%' OR REC_TIME like '%{1}%'";
             //   sqlText_Laser = string.Format(sqlText_Laser,Text1,Text2,Text3);
                // sqlText_Laser += "AND AREA_NAME like '%" + textBox1 .Text .Trim () + "%' ";
                //  string sqlText_Laser = string.Format("SELECT * FROM UACS_YARDMAP_AREA_DEFINE WHERE AREA_NAME like'%{0}%'",textBox1.Text.Trim());
                //初始化grid
                if (dataGridView1 .DataSource != null)
                {
                    dt_Laser.Clear();
                }
                using (IDataReader rdr = DBHelper.ExecuteReader(sqlText_Laser))
                {
                   
                        dt_Laser.Load(rdr);
                     
                        //mm = rdr["COIL_NO"].ToString();
                        //foreach (int ss in mm)
                        //{
                        //  //  int bb = int.Parse(dd);
                        //    if (ss == dd)
                        //    {
                        //        label3.Text = ss.ToString();

                        //    }

                        //     
                }
                dataGridView1.DataSource = dt_Laser;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\r\n" + er.StackTrace);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
