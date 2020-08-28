using Baosight.iSuperframe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSControls.CraneMonitor;
using UACSPopupForm.CraneMonitor;

namespace UACSView.View_CarneMeage
{
    public partial class Form_OrderManage : FormBase
    {
        public Form_OrderManage()
        {
            InitializeComponent();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            Form_PopEditOrder editOrderByWinForm = new Form_PopEditOrder();
           // editOrderByWinForm.OrderQueue = orderQueue;
            editOrderByWinForm.StartPosition = FormStartPosition.CenterScreen;
            editOrderByWinForm.ShowDialog();
        }




        //新增指令,finish
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Form_PopCreateOrder createOrderByWinForm = new Form_PopCreateOrder();
                createOrderByWinForm.StartPosition = FormStartPosition.CenterScreen;
                createOrderByWinForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
