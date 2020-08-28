using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL.CraneMonitor;

namespace UACSControls.CraneMonitor
{
    public partial class LineSlabInfoControl : UserControl
    {
        public LineSlabInfoControl()
        {
            InitializeComponent();
        }
        private void InitDataInfo()
        {
            
            lblMatNo1ByP1.Text = lblMatNo1ByP2.Text = lblMatNo1ByP3.Text = lblMatNo1ByP4.Text = lblMatNo1ByP5.Text = lblMatNo2ByP1.Text = lblMatNo2ByP2.Text = lblMatNo2ByP3.Text = lblMatNo2ByP4.Text = lblMatNo2ByP5.Text = labZ1.Text= labZ2.Text = labZ3.Text =labZ4.Text = labZ5.Text =
            lblTreamentNoByP1.Text = lblTreamentNoByP2.Text = lblTreamentNoByP3.Text = lblTreamentNoByP4.Text = lblTreamentNoByP5.Text = lblEnableFlagByP1.Text = lblEnableFlagByP2.Text = lblEnableFlagByP3.Text = lblEnableFlagByP4.Text = lblEnableFlagByP5.Text = string.Empty;
        }
        public void RefreshData(List<TLineSlabInfo> lst)
        {
            InitDataInfo();

            for (int i = 0; i < lst.Count; i++)
            {
                switch (lst[i].STOCK_NO)
                {
                    case "P1":
                        lblMatNo1ByP1.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP1.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP1.Text = lst[i].X;
                       lblEnableFlagByP1.Text = lst[i].Y;
                       labZ1.Text = lst[i].Z;
                        break;
                    case "P2":
                        lblMatNo1ByP2.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP2.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP2.Text = lst[i].X;
                    lblEnableFlagByP2.Text = lst[i].Y;
                        labZ2.Text = lst[i].Z;
                        break;
                    case "P3":
                        lblMatNo1ByP3.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP3.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP3.Text = lst[i].X;
                        lblEnableFlagByP3.Text = lst[i].Y;
                        labZ3.Text = lst[i].Z;
                        break;
                    case "P4":
                        lblMatNo1ByP4.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP4.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP4.Text = lst[i].X;
                        lblEnableFlagByP4.Text = lst[i].Y;
                        labZ4.Text = lst[i].Z;
                        break;
                    case "P5":
                        lblMatNo1ByP5.Text = lst[i].MAT_NO_1;
                        lblMatNo2ByP5.Text = lst[i].MAT_NO_2;
                        lblTreamentNoByP5.Text = lst[i].X;
                        lblEnableFlagByP5.Text = lst[i].Y;
                        labZ5.Text = lst[i].Z;
                        break;
                    default:
                        break;
                }
            }
            //InitDataInfo();
            ////lblOrderType.Text = CoverOrderTypeIntToStirng(craneOrderCurrent.ORDER_TYPE);
            ////lblMatNo1.Text = craneOrderCurrent.MAT_NO_1;
            ////lblMatNo2.Text = craneOrderCurrent.MAT_NO_2;
            //lblObjectType.Text = craneOrderCurrent.OBJECT_TYPE;
            //lblFromStockNo.Text = craneOrderCurrent.FROM_STOCK_NO;
            //lblToStockNo.Text = craneOrderCurrent.TO_STOCK_NO;
            //lblCmdStatus.Text = craneOrderCurrent.CMD_STATUS;
            //lblFromStockX.Text = craneOrderCurrent.FROM_STOCK_X.ToString();
            //lblFromStockY.Text = craneOrderCurrent.FROM_STOCK_Y.ToString();
            //lblFromStockZ.Text = craneOrderCurrent.FROM_STOCK_Z.ToString();
            //lblToStockX.Text = craneOrderCurrent.TO_STOCK_X.ToString();
            //lblToStockY.Text = craneOrderCurrent.TO_STOCK_Y.ToString();
            //lblToStockZ.Text = craneOrderCurrent.TO_STOCK_Z.ToString();
        }

        private void lblMatNo1ByP3_Click(object sender, EventArgs e)
        {

        }

        private void lblTreamentNoByP4_Click(object sender, EventArgs e)
        {

        }

        private void lblEnableFlagByP4_Click(object sender, EventArgs e)
        {

        }

        private void labZ4_Click(object sender, EventArgs e)
        {

        }

        private void lblMatNo1ByP1_Click(object sender, EventArgs e)
        {

        }

        private void lblTreamentNoByP3_Click(object sender, EventArgs e)
        {

        }

        private void LineSlabInfoControl_Click(object sender, EventArgs e)
        {
           
        }

        private void lblEnableFlagByP2_Click(object sender, EventArgs e)
        {

        }

        private void lblMat2ByP3_Click(object sender, EventArgs e)
        {

        }

        private void labZ5_Click(object sender, EventArgs e)
        {

        }

        private void LineSlabInfoControl_Load(object sender, EventArgs e)
        {

         }


    }
}
