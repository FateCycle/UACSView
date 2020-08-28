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
    public partial class Form_CraneCautionManage : FormBase
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
   
        public Form_CraneCautionManage()
        {
            InitializeComponent();
        }
        //下拉框绑定数据方法
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
        private void Form_CraneCautionManage_Load(object sender, EventArgs e)
        {
            GetComboxOnParking(CombTru);
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ButSelect_Click(object sender, EventArgs e)
        {
            //string date1 = dateTimeStart.Value.ToString("yyyy-MM-dd").Trim();
            //string date2 = dateTimeEnd.Value.ToString("yyyy-MM-dd ").Trim();
            //string Car = CombCar.Text.Trim();
            //string Text = textBox1.Text.Trim();
            //string sqlster1 = string.Format("select * from Alarm where Date between '{0}' and '{1}' or TrueMan='{2}' or Module='{3}'", date1,date2,Car,Text);
            //DataTable ta = new DataTable();
            //IDataReader nmm = DBHelper.ExecuteReader(sqlster1);
            //dataGridView1.DataSource = nmm;

            //string sql = @"select C.GROOVEID,C.MAT_NO as COIL_NO2,A.LOT_NO as LOT_NO,C.X_CENTER as GROOVE_ACT_X ,C.Y_CENTER AS GROOVE_ACT_Y,C.Z_CENTER AS GROOVE_ACT_Z, B.WEIGHT, B.OUTDIA ,D.STOCK_NO, D.LOCK_FLAG,B.PACK_FLAG  from UACS_TRUCK_STOWAGE_DETAIL C ";
            //sql += " LEFT JOIN  UACS_PLAN_L3PICK A ON C.MAT_NO = A.COIL_NO ";
            //sql += " LEFT JOIN  UACS_YARDMAP_COIL B ON C.MAT_NO = B.COIL_NO ";
            //sql += " LEFT JOIN UACS_YARDMAP_STOCK_DEFINE D ON C.MAT_NO = D.MAT_NO ";
            //sql += string.Format(" where STOWAGE_ID = '{0}' order by C.GROOVEID", strStowageID);
            //DataGridViewBindingSource(dataGridView2, sql);

        }
        //报警信息查询
        private void ButSelect_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TxtCode.Text.Trim() == "" && CombTru.Text .Trim ()=="")
                {
                    dt_Laser.Clear();
                    dataGridView1.DataSource = dt_Laser;
                    return;
                }
                //获取查询条件
                string date1 = dateTimeStart.Value.ToString("yyyy-MM-dd").Trim();
                string date2 = dateTimeEnd.Value.ToString("yyyy-MM-dd").Trim();
                string Code = TxtCode.Text.Trim();
                string TrueType = CombTru.Text.Trim();
                //报警信息
                string sqlText = @"SELECT GROOVE_ACT_X, GROOVE_ACT_Y, GROOVE_ACT_Z, GROOVEID FROM UACS_LASER_OUT ";
                sqlText += "WHERE Date between '{0}' and '{1}' or TrueMan like '%{2}%' or Module like '%{3}%'";
               sqlText = string.Format(sqlText, date1,date2,Code,TrueType);

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

        private void CombTru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PalMiddle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
