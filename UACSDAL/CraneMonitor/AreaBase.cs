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
        private string  sAFE_AREA_1;
        /// <summary>
        ///红一区
        /// </summary>
        public string  SAFE_AREA_1
        {
            get { return sAFE_AREA_1; }
            set { sAFE_AREA_1 = value; }

        }
        private string  sAFE_AREA_2;
        /// <summary>
        ///红二区
        /// </summary>
        public string  SAFE_AREA_2
        {
            get { return sAFE_AREA_2; }
            set { sAFE_AREA_2 = value; }

        }
        private string  sAFE_AREA_3;
        /// <summary>
        ///红三区
        /// </summary>
        public string  SAFE_AREA_3
        {
            get { return sAFE_AREA_3; }
            set { sAFE_AREA_3 = value; }

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
        private int parking_STATUS;
        /// <summary>
        /// 火车状态信息
        /// </summary>
        public int Parking_STATUS
        {
            get { return parking_STATUS; }
            set { parking_STATUS = value; }
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

        // STOCK_STATUS
        private string sTOCK_STATUS;
        /// <summary>
        /// 盖状态
        /// </summary>
        public string STOCK_STATUS
        {
            get { return sTOCK_STATUS; }
            set { sTOCK_STATUS = value; }
        }

        private string stockNo;
        /// <summary>
        /// 盖名称
        /// </summary>
        public string STOCK_NO
        {
            get { return stockNo; }
            set { stockNo = value; }
        }
        private string enable_flag;
        /// <summary>
        /// 盖名称
        /// </summary>
        public string ENABLE_FLAG
        {
            get { return enable_flag; }
            set { enable_flag = value; }
        }
        private string enable_num;
        /// <summary>
        /// 盖名层数
        /// </summary>
        public string ENABLE_NUM
        {
            get { return enable_num; }
            set { enable_num = value; }
        }
        private int pSTOCK_STATUS;
        /// <summary>
        /// 火车盖状态
        /// </summary>
        public int PSTOCK_STATUS
        {
            get { return pSTOCK_STATUS; }
            set { pSTOCK_STATUS = value; }
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
        private long sAFE_AREA_1_Value;
        /// <summary>
        ///红一区
        /// </summary>
        public long SAFE_AREA_1_Value
        {
            get { return sAFE_AREA_1_Value; }
            set { sAFE_AREA_1_Value = value; }

        }
        private long sAFE_AREA_2_Value;
        /// <summary>
        ///红二区
        /// </summary>
        public long SAFE_AREA_2_Value
        {
            get { return sAFE_AREA_2_Value; }
            set { sAFE_AREA_2_Value = value; }

        }
        private long sAFE_AREA_3_Value;
        /// <summary>
        ///红三区
        /// </summary>
        public long SAFE_AREA_3_Value
        {
            get { return sAFE_AREA_3_Value; }
            set { sAFE_AREA_3_Value = value; }

        }
        private long safe_door1;
        /// <summary>
        /// 安全门信号1
        /// </summary>
        public long Safe_door1
        {
            get { return safe_door1; }
            set { safe_door1 = value; }

        }
        private long safe_door2;
        /// <summary>
        /// 安全门信号2
        /// </summary>
        public long Safe_door2
        {
            get { return safe_door2; }
            set { safe_door2 = value; }

        }
        private long safe_door3;
        /// <summary>
        /// 安全门信号3
        /// </summary>
        public long Safe_door3
        {
            get { return safe_door3; }
            set { safe_door3 = value; }

        }
        private long safe_door4;
        /// <summary>
        /// 安全门信号4
        /// </summary>
        public long Safe_door4
        {
            get { return safe_door4; }
            set { safe_door4 = value; }

        }
        private long safe_door5;
        /// <summary>
        /// 安全门信号4
        /// </summary>
        public long Safe_door5
        {
            get { return safe_door5; }
            set { safe_door5 = value; }

        }

    }
}
