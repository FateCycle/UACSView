using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL.CraneMonitor;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using System.Media;
using System.Net;
namespace UACSControls.CraneMonitor
{
    public partial class MANUALControl : UserControl
    {
        public MANUALControl()
        {
            InitializeComponent();
        }
        private void InitDataInfo()
        {

            lblMatNo1ByP1.Text = lblMatNo1ByP2.Text = lblMatNo1ByP3.Text = lblMatNo1ByP4.Text = lblMatNo1ByP5.Text = lblMatNo2ByP1.Text = lblMatNo2ByP2.Text = lblMatNo2ByP3.Text = lblMatNo2ByP4.Text = lblMatNo2ByP5.Text = 
            lblTreamentNoByP1.Text = lblTreamentNoByP2.Text = lblTreamentNoByP3.Text = lblTreamentNoByP4.Text = lblTreamentNoByP5.Text = lblEnableFlagByP1.Text = lblEnableFlagByP2.Text = lblEnableFlagByP3.Text = lblEnableFlagByP4.Text = lblEnableFlagByP5.Text = string.Empty;
        }

        public void RefreshData(List<ManualInfo> lst)
        {
            InitDataInfo();

            for (int i = 0; i < lst.Count; i++)
            {
                switch (lst[i].STOCK_NO)
                {
                    case "POS1":
                        lblMatNo1ByP1.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP1.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP1.Text = lst[i].X;
                        lblEnableFlagByP1.Text = lst[i].Y;
                    //     labZ1.Text = lst[i].Z;
                        break;
                    case "POS2":
                        lblMatNo1ByP2.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP2.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP2.Text = lst[i].X;
                        lblEnableFlagByP2.Text = lst[i].Y;
                     //    labZ2.Text = lst[i].Z;
                        break;
                    case "POS3":
                        lblMatNo1ByP3.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP3.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP3.Text = lst[i].X;
                        lblEnableFlagByP3.Text = lst[i].Y;
                   //    labZ3.Text = lst[i].Z;
                        break;
                    case "POS4":
                        lblMatNo1ByP4.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP4.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP4.Text = lst[i].X;
                        lblEnableFlagByP4.Text = lst[i].Y;
                    //   labZ4.Text = lst[i].Z;
                        break;
                    case "POS5":
                        lblMatNo1ByP5.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP5.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP5.Text = lst[i].X;
                        lblEnableFlagByP5.Text = lst[i].Y;
                      //  labZ5.Text = lst[i].Z;
                        break;
                    default:
                        break;
                }
            }
    
        }
        private void labZ5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEnableFlagByP5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void MANUALControl_Load(object sender, EventArgs e)
        {
           // ContextMenuStrip = contextMenuStrip1;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
