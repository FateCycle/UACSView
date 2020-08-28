using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL.CraneMonitor
{
    public class TCraneOrderInfo
    {
        private string craneNo;

        public string CRANE_NO
        {
            get { return craneNo; }
            set { craneNo = value; }
        }
        private int orderNo;

        public int ORDER_NO
        {
            get {return orderNo; }
            set {orderNo = value; }
        }
        private int orderType;

        public int ORDER_TYPE
        {
            get { return orderType; }
            set { orderType = value; }
        }
        private string orderTypeL3;

        public string ORDER_TYPE_L3
        {
            get { return orderTypeL3; }
            set { orderTypeL3 = value; }
        }
        private string matNo1;

        public string MAT_NO_1
        {
            get { return matNo1; }
            set { matNo1 = value; }
        }
        private string matNo2;

        public string MAT_NO_2
        {
            get { return matNo2; }
            set { matNo2 = value; }
        }
        private string fromStockNo;

        public string FROM_STOCK_NO
        {
            get { return fromStockNo; }
            set { fromStockNo = value; }
        }
        private string toStockNo;

        public string TO_STOCK_NO
        {
            get { return toStockNo;}
            set { toStockNo = value;}
        }
        private string objectType;

        public string OBJECT_TYPE
        {
            get { return objectType; }
            set { objectType = value; }
        }
        private string cmdStatus;

        public string CMD_STATUS
        {
            get { return cmdStatus; }
            set { cmdStatus = value; }
        }
        private int fromStockX;

        public int FROM_STOCK_X
        {
            get { return fromStockX; }
            set { fromStockX = value; }
        }
        private int fromStockY;

        public int FROM_STOCK_Y
        {
            get { return fromStockY; }
            set { fromStockY = value; }
        }
        private int fromStockZ;

        public int FROM_STOCK_Z
        {
            get { return fromStockZ; }
            set { fromStockZ = value; }
        }
        private int layerNo;

        public int LAYER_NO
        {
            get { return layerNo; }
            set { layerNo = value; }
        }
        private int toStockX;

        public int TO_STOCK_X
        {
            get { return toStockX; }
            set { toStockX = value; }
        }
        private int toStockY;

        public int TO_STOCK_Y
        {
            get { return toStockY; }
            set { toStockY = value; }
        }
        private int toStockZ;

        public int TO_STOCK_Z
        {
            get { return toStockZ; }
            set { toStockZ = value; }
        }

    }
}
