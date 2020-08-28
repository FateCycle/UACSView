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
    public partial class OrderByManualControl : UserControl
    {
        public OrderByManualControl()
        {
            InitializeComponent();
        }
        private string craneNo;

        public string CRANE_NO
        {
            get { return craneNo; }
            set { craneNo = value;lblCraneNo.Text = craneNo; }
        }
        private void InitDataInfo()
        {
            lblCmdStatus.Text = lblFromStockNo.Text = lblToStockNo.Text =/* lblMatNo1.Text = lblMatNo2.Text =*/ lblObjectType.Text  = /*lblOrderType.Text =*/
                lblFromStockX.Text = lblFromStockY.Text = lblFromStockZ.Text = lblToStockX.Text = lblToStockY.Text = lblToStockZ.Text = string.Empty;
        }
        public void RefreshData(TCraneOrderInfo craneOrderCurrent)
        {
            InitDataInfo();
            //lblOrderType.Text = CoverOrderTypeIntToStirng(craneOrderCurrent.ORDER_TYPE);
            //lblMatNo1.Text = craneOrderCurrent.MAT_NO_1;
            //lblMatNo2.Text = craneOrderCurrent.MAT_NO_2;
            lblObjectType.Text = craneOrderCurrent.OBJECT_TYPE;
            lblFromStockNo.Text = craneOrderCurrent.FROM_STOCK_NO;
            lblToStockNo.Text = craneOrderCurrent.TO_STOCK_NO;
            lblCmdStatus.Text = craneOrderCurrent.CMD_STATUS;
            lblFromStockX.Text = craneOrderCurrent.FROM_STOCK_X.ToString();
            lblFromStockY.Text = craneOrderCurrent.FROM_STOCK_Y.ToString();
            lblFromStockZ.Text = craneOrderCurrent.FROM_STOCK_Z.ToString();
            lblToStockX.Text = craneOrderCurrent.TO_STOCK_X.ToString();
            lblToStockY.Text = craneOrderCurrent.TO_STOCK_Y.ToString();
            lblToStockZ.Text = craneOrderCurrent.TO_STOCK_Z.ToString();
        }

        private void lblToStockZ_Click(object sender, EventArgs e)
        {

        }
        //private string CoverOrderTypeIntToStirng(int ordertype)
        //{
        //    string orderTypeStr = string.Empty;
        //    switch (ordertype)
        //    {
        //        case 20:
        //            orderTypeStr = "机组入保温坑";
        //            break;
        //        case 21:
        //            orderTypeStr = "机组去临时堆放区";
        //            break;
        //        case 22:
        //            orderTypeStr = "机组上火车";
        //            break;
        //        case 23:
        //            orderTypeStr = "保温坑上火车";
        //            break;
        //        case 24:
        //            orderTypeStr = "吊运保温盖";
        //            break;
        //        case 25:
        //            orderTypeStr = "行车激光扫描";
        //            break;
        //        default:
        //            orderTypeStr = "未知类型";
        //            break;
        //    }
        //    return orderTypeStr;
        //}
    }
}
