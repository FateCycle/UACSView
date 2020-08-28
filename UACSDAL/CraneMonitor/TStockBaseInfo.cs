using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL.CraneMonitor
{
     public class TStockBaseInfo
    {
        private string stockNo;

        public string STOCK_NO
        {
            get { return stockNo; }
            set { stockNo = value; }
        }

        private string enable;

        public string ENABLE
        {
            get { return enable; }
            set { enable = value; }
        }
        private int stockSeq;

        public int STOCK_SEQ
        {
            get { return stockSeq; }
            set { stockSeq = value; }
        }
        private string location;

        public string LOCATION
        {
            get { return location; }
            set { location = value; }
        }
        private string areaNo;

        public string AREA_NO
        {
            get { return areaNo; }
            set { areaNo = value; }
        }
        private string stockStatus;

        public string STOCK_STATUS
        {
            get { return stockStatus; }
            set { stockStatus = value; }
        }
        private string stockType;

        public string STOCK_TYPE
        {
            get { return stockType; }
            set { stockType = value; }
        }
        private int xCenter;

        public int XCENTER
        {
            get { return xCenter; }
            set { xCenter = value; }
        }
        private int yCenter;

        public int YCENTER
        {
            get { return yCenter; }
            set { yCenter = value; }
        }
        private int zCenter;

        public int ZCENTER
        {
            get { return zCenter; }
            set { zCenter = value; }
        }
        private int stockLength;

        public int STOCK_LENGTH
        {
            get { return stockLength; }
            set { stockLength = value; }
        }
        //public void ClearInfo()
        //{
        //    matNo1 = matNo2 =/*enableFlag= treatmentNo = */string.Empty;
        //}
    }
}
