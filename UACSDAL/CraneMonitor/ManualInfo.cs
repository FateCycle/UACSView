using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL.CraneMonitor
{
    public class ManualInfo
    {
        private string stockNo;

        public string STOCK_NO
        {
            get { return stockNo; }
            set { stockNo = value; }
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

        private string x;

        public string X
        {
            get { return x; }
            set { x = value; }
        }
        private string y;

        public string Y
        {
            get { return y; }
            set { y = value; }
        }
        private string z;

        public string Z
        {
            get { return z; }
            set { z = value; }
        }
        private string treatmentNo;

        public string TREATMENT_NO
        {
            get { return treatmentNo; }
            set { treatmentNo = value; }
        }
        private string enableFlag;

        public string ENABLE_FLAG
        {
            get { return enableFlag; }
            set { enableFlag = value; }
        }
        private string Park_POS;
        public string PARK_POS
        {
            get { return Park_POS; }
            set { Park_POS = value; }
        }
        private string load_FLAG;
        public string LOAD_FLAG
        {
            get { return load_FLAG; }
            set { load_FLAG = value; }
        }

        private string stock_STATUS;
        public string STOCK_STATUS
        {
            get { return stock_STATUS; }
            set { stock_STATUS = value; }
        }
        public void ClearInfo1()
        {
            load_FLAG =/*labSTATUS= */string.Empty;
        }
        public void ClearInfo()
        {
            matNo1 = matNo2 =/*enableFlag= treatmentNo = */string.Empty;
        }
    }
}
