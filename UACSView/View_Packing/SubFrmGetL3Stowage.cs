using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;

namespace UACSView.View_Packing
{
    public partial class SubFrmGetL3Stowage : Form
    {
        private string stowageID = "";

        public string StowageID
        {
            get { return stowageID; }
            set { stowageID = value; }
        }
        public SubFrmGetL3Stowage()
        {
            InitializeComponent();
            this.Load += SubFrmGetL3Stowage_Load;
        }
         public SubFrmGetL3Stowage(string stowageID)
        {
            InitializeComponent();
            StowageID = stowageID;
            this.Load += SubFrmGetL3Stowage_Load;
        }

        void SubFrmGetL3Stowage_Load(object sender, EventArgs e)
        {
            ManagerHelper.DataGridViewInit(dgvStowage);
            CreakConlumcheckBox(dgvStowage);
            dgvStowage.CellContentClick += dgvStowage_CellContentClick;
        }

        void dgvStowage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                dgv.Rows[e.RowIndex].Cells[0].Value = (bool)dgv.Rows[e.RowIndex].Cells[0].EditedFormattedValue;
            }
        }
        #region 网格添加单选框

        private void CreakConlumcheckBox(DataGridView dgv)
        {
            var cell = dgv.GetCellDisplayRectangle(0, -1, true);
            //var checkbox = new CheckBox { Left = cell.Size.Width - 20, Top = cell.Top + 10, Width = 16, Height = 16 };
            var checkbox = new CheckBox { Left = cell.Size.Width - 20, Top = cell.Size.Height / 2 - 8, Width = 16, Height = 16 };
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            dgv.Controls.Add(checkbox);
        }

        void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                //foreach (DataGridViewRow item in dgvPlanOut.Rows)
                //{
                //    if (i == 8)
                //    {
                //        break;
                //    }
                //    clsCoils coil = new clsCoils();
                //    coil.MAT_NO = item.Cells["MAT_NO"].Value.ToString();
                //    coil.PLAN_NO = item.Cells["PLAN_NO"].Value.ToString();
                //    coil.ColumnNO = item.Cells["STOCK_NO"].Value.ToString();
                //    listViewCoil.Items.Add(coil);
                //    item.Cells["CHECK_COLUMN"].Value = true;
                //    txtSelectCoilSNum.Text = (listViewCoil.Items.Count - 1).ToString();
                //    i++;
                //}
            }
            else if (!cb.Checked)
            {
                //int k = 0;
                //foreach (DataGridViewRow item in dgvPlanOut.Rows)
                //{
                //    foreach (clsCoils item1 in listViewCoil.Items)
                //    {
                //        if (item1.MAT_NO == item.Cells["MAT_NO"].Value.ToString())
                //        {
                //            listViewCoil.Items.Remove(item1);
                //            item.Cells["CHECK_COLUMN"].Value = false;
                //            k++;
                //            break;
                //        }
                //    }
                //    if (k > 8)
                //    {
                //        break;
                //    }
                //}
            }

        } 
        #endregion

        #region 获取L3配载
        
        private void getL3StowageDetail(string stowageID)
        {
            string sqlstr = "";
            try
            {
                using (IDataReader rdr = ManagerHelper.DBHelper.ExecuteReader(sqlstr))
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}\r\n{1}", ex.StackTrace.ToString(), ex.Message.ToString()));
            }
        }

        #endregion

        private void dgvStowage_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SubFrmGetL3Stowage_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
