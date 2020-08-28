using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL
{

    /// <summary>
    /// 小区基类
    /// </summary>
    public class AreaBase : ICloneable
    {
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public AreaBase Clone()
        {
            return (AreaBase)this.MemberwiseClone();
        }
        private string areaNo;
        /// <summary>
        /// 小区
        /// </summary>
        public string AreaNo
        {
            get { return areaNo; }
            set { areaNo = value; }
        }

        private int areaType;
        /// <summary>
        /// 小区类别
        /// </summary>
        public int AreaType
        {
            get { return areaType; }
            set { areaType = value; }
        }

        private string area_Name;
        /// <summary>
        /// 昵称
        /// </summary>
        public string Area_Name
        {
            get { return area_Name; }
            set { area_Name = value; }
        }
        

        private string bayNo;
        /// <summary>
        /// 跨别
        /// </summary>
        public string BayNo
        {
            get { return bayNo; }
            set { bayNo = value; }
        }


        private long x_Start;
        /// <summary>
        /// X起
        /// </summary>
        public long X_Start
        {
            get { return x_Start; }
            set { x_Start = value; }
        }

        private long x_End;
        /// <summary>
        /// X终
        /// </summary>
        public long X_End
        {
            get { return x_End; }
            set { x_End = value; }
        }

        private long y_Start;
        /// <summary>
        /// Y起
        /// </summary>
        public long Y_Start
        {
            get { return y_Start; }
            set { y_Start = value; }
        }

        private long y_End;
        /// <summary>
        /// Y终
        /// </summary>
        public long Y_End
        {
            get { return y_End; }
            set { y_End = value; }
        }


        private long areaWidth;
        /// <summary>
        /// 小区宽度
        /// </summary>
        public long AreaWidth
        {
            get { return areaWidth; }
            set 
            {
                areaWidth = x_End - x_Start;
            }
        }

        private long areaHeight;
        /// <summary>
        /// 小区宽度
        /// </summary>
        public long AreaHeight
        {
            get { return areaHeight; }
            set
            {
                areaHeight = y_End - y_Start;
            }
        }


        private int areaSaddleNum;
        /// <summary>
        /// 小区鞍座数
        /// </summary>
        public int AreaSaddleNum
        {
            get { return areaSaddleNum; }
            set { areaSaddleNum = value; }
        }


        private int areaSaddleNoCoilNum;
        /// <summary>
        /// 小区空鞍座
        /// </summary>
        public int AreaSaddleNoCoilNum
        {
            get { return areaSaddleNoCoilNum; }
            set { areaSaddleNoCoilNum = value; }
        }


        private int areaSaddleCoilNum;
        /// <summary>
        /// 小区有卷鞍座
        /// </summary>
        public int AreaSaddleCoilNum
        {
            get { return areaSaddleCoilNum; }
            set { areaSaddleCoilNum = value; }
        }


        private string tBayNO;
        /// <summary>
        /// 跨别
        /// </summary>
        public string TBayNO
        {
            get { return tBayNO; }
            set { tBayNO = value; }
        }


        private string tAreaNo;
        /// <summary>
        /// 小区
        /// </summary>
        public string TAreaNo
        {
            get { return tAreaNo; }
            set { tAreaNo = value; }
        }

        private long areaDoorSefeValue;

        public long AreaDoorSefeValue
        {
            get { return areaDoorSefeValue; }
            set { areaDoorSefeValue = value; }
        }

        private string areaDoorSefeName;

        public string AreaDoorSefeName
        {
            get { return areaDoorSefeName; }
            set { areaDoorSefeName = value; }
        }

        private long areaDoorReserveValue;

        public long AreaDoorReserveValue
        {
            get { return areaDoorReserveValue; }
            set { areaDoorReserveValue = value; }
        }

        private string areaDoorReserveName;

        public string AreaDoorReserveName
        {
            get { return areaDoorReserveName; }
            set { areaDoorReserveName = value; }
        }
    }
}
