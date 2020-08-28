using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace UACSDAL
{
    /// <summary>
    /// 小区处理数据类
    /// </summary>
    public class AreaInfo
    {
        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDataProvider = new Baosight.iSuperframe.TagService.Controls.TagDataProvider();
     //   private Baosight.iSuperframe.TagService.DataCollection<object> inDatas = new Baosight.iSuperframe.TagService.DataCollection<object>();
        /// <summary>
        /// 地坑保温盖
        /// </summary>
        public static string STOCK_TYPE_HOTPIT_COVER = "HOTPITCAP";
        /// <summary>
        /// 火车保温盖
        /// </summary>
        public static string STOCK_TYPE_TRAIN_COVER = "TRAINCAP";
        /// <summary>
        /// 保温坑盖堆放区
        /// </summary>
        public static string STOCK_TYPE_HOTPIT_AREA = "HOTPITCAP_TMP";
        //TRAINCAP_TMP
        /// <summary>
        /// 火车盖放区
        /// </summary>
        public static string STOCK_TYPE_PACKING_AREA = "TRAINCAP_TMP";
        /// <summary>
        /// 地坑保温盖
        /// </summary>
        public static string STOCK_OCCUPY_STATUS = "OCCUPY";
        /// <summary>
        /// 火车保温盖
        /// </summary>
        public static string STOCK_EMPTY_STATUS = "EMPTY";
        /// <summary>
        /// 安全门
        /// </summary>
        public static string STOCK_Door_STATUS = "Door";
        /// <summary>
        /// 红一区
        /// </summary>
        public static string ADRESS_SAFE_AREA1 = "SAFE_AREA_1";
        /// <summary>
        /// 红二区
        /// </summary>
        public static string ADRESS_SAFE_AREA2 = "SAFE_AREA_2";
        /// <summary>
        /// 红三区
        /// </summary>
        public static string ADRESS_SAFE_AREA3 = "SAFE_AREA_3";
        /// <summary>
        /// 安全门1
        /// </summary>
        public static string ADRESS_SAFE_DOOR1 = "SAFE_DOOR_Lock1";
        /// <summary>
        /// 安全门2
        /// </summary>
        public static string ADRESS_SAFE_DOOR2 = "SAFE_DOOR_Lock2";
        /// <summary>
        /// 安全门3
        /// </summary>
        public static string ADRESS_SAFE_DOOR3 = "SAFE_DOOR_Lock3";
        /// <summary>
        /// 安全门4
        /// </summary>
        public static string ADRESS_SAFE_DOOR4 = "SAFE_DOOR_Lock4";
        /// <summary>
        /// 安全门5
        /// </summary>
        public static string ADRESS_SAFE_DOOR5 = "SAFE_DOOR_Lock5";
        //public string  saddlenum = "";
        //public  string AreaName = "";
        public enum AreaType
        {
            /// <summary>
            /// 全部类别
            /// </summary>
            AllType,
            /// <summary>
            /// 库内库区
            /// </summary>
            StockArea,
            /// <summary>
            /// 机组库区
            /// </summary>
            UnitArea,
            /// <summary>
            /// 保温坑区域
            /// </summary>
            HotPitArea,
            /// <summary>
            /// 保温盖区域
            /// </summary>
            HotPitCoverArea = 10,
            /// <summary>
            /// 保温盖堆放区域
            /// </summary>
            HotPitCoverTemp,
            /// <summary>
            /// 火车停车位
            /// </summary>
            TrainParkingArea,
            /// <summary>
            /// 火车车厢区域
            /// </summary>
            TrainBoxArea,
            /// <summary>
            /// 火车车厢区域
            /// </summary>
            TrainCoverArea,
            /// <summary>
            /// 火车盖区域
            /// </summary>
            TrainCoverTemp,
            /// <summary>
            /// 临时区域
            /// </summary>
            TemporaryArea = 9,
            /// <summary>
            /// 机组区域
            /// </summary>
            AircrewArea = 5,
            /// <summary>
            /// 通道区域
            /// </summary>
            PassagewagArea = 1,
            /// <summary>
            /// 安全线
            /// </summary>
            SecurityLine = 6,
            /// <summary>
            /// 安全门
            /// </summary>
            SecurityDoor,
            /// <summary>
            /// 红区
            /// </summary>
            RedArea,
            /// <summary>
            /// 除了库区不显示其他都显示
            /// </summary>
            NoStockAndRestsType,
            /// <summary>
            /// 第二节车厢
            /// </summary>
            SecondTrain =13,
            /// <summary>
            /// 井字架
            /// </summary>
            JinFrame = 16,
            /// <summary>
            /// 第一节车厢
            /// </summary>
            FirstTrain = 12,
            ///<summary>
            /// 第三节车厢
            ///</summary>
            ThirdTrain = 11,




        }




        private string bayNo = string.Empty;
        /// <summary>
        /// 跨别
        /// </summary>
        public string BayNo
        {
            get { return bayNo; }
        }

        private AreaType areaTypeS;
        /// <summary>
        /// 显示库区类别
        /// </summary>
        public AreaType AreaTypeS
        {
            get { return areaTypeS; }
        }

        private string cOIL_NO;
        /// <summary>
        /// 方坯号
        /// </summary>
        public string COIL_NO
        {
            get { return cOIL_NO; }
            set { cOIL_NO = value; }
        }
        public void conInit(string theBayNo,AreaType _areaType,string tagServiceName)
        {
            try
            {
                bayNo = theBayNo;
                areaTypeS = _areaType;
                tagDataProvider.ServiceName = tagServiceName;

            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 存储每个鞍座对应的数据（字典）
        /// </summary>
        private Dictionary<string, AreaBase> dicSaddles = new Dictionary<string, AreaBase>();
        public Dictionary<string, AreaBase> DicSaddles
        {
            get { return dicSaddles; }
            set { dicSaddles = value; }
        }
      

        private Dictionary<string, AreaInfo> dicSaddles1 = new Dictionary<string ,AreaInfo>();
        public Dictionary<string,AreaInfo > DicSaddles1
        {
            get { return dicSaddles1; }
            set { dicSaddles1 = value; }

        }

        /// <summary>
        /// 查找部分对应数据(不包括小区)
        /// </summary>
        public void getPortionAreaData()
        {
            string sql = null;                    
            try
            {
                // 标记用于区分小区类别
                sql = "SELECT AREA_NO,X_START,X_END,Y_START,Y_END,AREA_TYPE,AREA_NAME FROM UACS_YARDMAP_AREA_DEFINE WHERE BAY_NO LIKE '" + bayNo + "%' ORDER BY AREA_NO DESC";
                #region
                //if (areaTypeS == AreaType.CarArea)
                //{
                //    sql += " WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE = 1";
                //}
                //else if (areaTypeS == AreaType.StockArea)
                //{
                //    sql += " WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE = 0";
                //}
                //else if (areaTypeS == AreaType.UnitArea)
                //{
                //    sql +=" WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE in (4,5)";  //机组出入口
                //}
                //else if (areaTypeS == AreaType.NoStockAndRestsType)
                //{
                //    sql += " WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE != 0";
                //}
                //else
                //{
                //    sql += " WHERE BAY_NO LIKE '" + bayNo + "%' ";
                //}
                #endregion
                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        AreaBase theArea = new AreaBase();
                        if (rdr["AREA_NO"] != System.DBNull.Value)
                        {
                          
                            if (rdr["AREA_NO"] != System.DBNull.Value)
                            {
                                theArea.AreaNo = Convert.ToString(rdr["AREA_NO"]);
                            }
                            if (rdr["X_START"] != System.DBNull.Value)
                            {
                                theArea.X_Start = Convert.ToInt32(rdr["X_START"]);
                            }
                            if (rdr["X_END"] != System.DBNull.Value)
                            {
                                theArea.X_End = Convert.ToInt32(rdr["X_END"]);
                            }
                            if (rdr["Y_START"] != System.DBNull.Value)
                            {
                                theArea.Y_Start = Convert.ToInt32(rdr["Y_START"]);
                            }
                            if (rdr["Y_END"] != System.DBNull.Value)
                            {
                                theArea.Y_End = Convert.ToInt32(rdr["Y_END"]);
                            }
                            if (rdr["AREA_TYPE"] != System.DBNull.Value)
                            {
                                theArea.AreaType = Convert.ToInt32(rdr["AREA_TYPE"]);
                            }
                            if (rdr["AREA_NAME"] != System.DBNull.Value)
                            {
                                theArea.Area_Name = Convert.ToString(rdr["AREA_NAME"]);
                            }
                            #region
                            if (theArea.AreaType == 0)
                            {
                                theArea.AreaSaddleNum = getAreaSaddleNum(theArea.AreaNo);

                                theArea.AreaSaddleNoCoilNum = getAreaSaddleNoCoilNum(theArea.AreaNo);

                                theArea.AreaSaddleCoilNum = getAreaSaddleCoilNum(theArea.AreaNo);

                              //  theArea.TBayNO = theArea.AreaNo.Substring(0, 3);

                              //  theArea.TAreaNo = theArea.AreaNo.Substring(6, theArea.AreaNo.Count() - 6);

                                //StringBuilder sbTagName_Safe = new StringBuilder("AREA_SAFE_");
                                //sbTagName_Safe.Append(theArea.TBayNO);
                                //sbTagName_Safe.Append("_");
                                //sbTagName_Safe.Append(theArea.TAreaNo);

                            //  theArea.AreaDoorSefeName = sbTagName_Safe.ToString();

                           //  StringBuilder sbTagName_Reserve1 = new StringBuilder("SAFE_");
                            //    sbTagName_Reserve.Append(theArea.TBayNO);
                              //  sbTagName_Reserve.Append("_");
                              //  sbTagName_Reserve1.Append(theArea.AreaNo);

                              //  theArea.SAFE_AREA_1 = sbTagName_Reserve1.ToString();

                              //  StringBuilder sbTagName_Reserve2 = new StringBuilder("SAFE_");
                                //    sbTagName_Reserve.Append(theArea.TBayNO);
                                //  sbTagName_Reserve.Append("_");
                              //  sbTagName_Reserve2.Append(theArea.AreaNo);

                             //   theArea.SAFE_AREA_2 = sbTagName_Reserve2.ToString();

                             //   StringBuilder sbTagName_Reserve3 = new StringBuilder("SAFE_");
                                //    sbTagName_Reserve.Append(theArea.TBayNO);
                                //  sbTagName_Reserve.Append("_");
                             //   sbTagName_Reserve3.Append(theArea.AreaNo);

                              //  theArea.SAFE_AREA_3 = sbTagName_Reserve3.ToString();

                            }
                      //     AreaName = theArea.Area_Name;
                            #endregion
                            if (theArea.AreaType== Convert.ToInt32(AreaType.HotPitCoverArea)|| theArea.AreaType == Convert.ToInt32(AreaType.TrainCoverArea) || theArea.AreaType == Convert.ToInt32(AreaType.HotPitCoverTemp) || theArea.AreaType == Convert.ToInt32(AreaType.TrainCoverTemp))
                            {
                                sql =string.Format(@"SELECT B.STOCK_STATUS,B.STOCK_NO,B.ENABLE,B.LAYER_NO FROM UACS_YARDMAP_AREA_DEFINE A left join UACS_YARDMAP_TRAIN_STOCK_DEFINE B on A.AREA_NO = B.AREA_NO WHERE A.AREA_NO = '{0}' and B.STOCK_TYPE  IN ('{1}','{2}','{3}','{4}')", theArea.AreaNo,STOCK_TYPE_HOTPIT_COVER,STOCK_TYPE_TRAIN_COVER,STOCK_TYPE_HOTPIT_AREA,STOCK_TYPE_PACKING_AREA);
                                using (IDataReader rdrByCover = DB2Connect.DBHelper.ExecuteReader(sql))
                                {
                                    if (rdrByCover.Read())
                                    {
                                        theArea.STOCK_STATUS = rdrByCover["STOCK_STATUS"].ToString();
                                        theArea.STOCK_NO = rdrByCover["STOCK_NO"].ToString();
                                        theArea.ENABLE_FLAG = rdrByCover["ENABLE"].ToString();
                                        theArea.ENABLE_NUM = rdrByCover["LAYER_NO"].ToString();

                                    }
                                }
                            }
                            #region
                            //    //查询所有保温坑盖情况
                            //    sql = @"SELECT B.STOCK_STATUS as num FROM UACS_YARDMAP_AREA_DEFINE A left join UACS_YARDMAP_TRAIN_STOCK_DEFINE B on A.STOCK_NO = B.STOCK_NO
                            //                        WHERE A.AREA_NO = '" + theArea.AreaNo + "' and B.STOCK_TYPE ='HOTPITCAP'";
                            //    using (IDataReader rdr2 = DB2Connect.DBHelper.ExecuteReader(sql))
                            //        {
                            //            while (rdr2.Read())
                            //            {
                            //                if (rdr2["num"] != DBNull.Value)
                            //                    theArea.STOCK_STATUS = rdr2["num"].ToString();
                            //            }
                            //        }
                            //    //查询火车盖情况
                            ////    A.AREA_NAME = '" + AreaName + "' and
                            // sql = @"SELECT B.STOCK_STATUS as num FROM UACS_YARDMAP_AREA_DEFINE A left join UACS_YARDMAP_TRAIN_STOCK_DEFINE B on A.AREA_NO = B.STOCK_NO
                            //                        WHERE  A.AREA_NAME = '" + AreaName + "' and B.STOCK_TYPE = 'TRAINCAP' ";
                            //    using (IDataReader rdr3 = DB2Connect.DBHelper.ExecuteReader(sql))
                            //    {
                            //        while (rdr3.Read())
                            //        {
                            //            if (rdr3["num"] != DBNull.Value)
                            //                theArea.PSTOCK_STATUS =Convert.ToInt32( rdr3["num"]);
                            //        }
                            //    }
                            //    //查询火车状态信息
                            //    sql = @"select PARKING_STATUS as num from UACS_PARKING_STATUS  WHERE PARKING_NO ='CC1TV01' ";
                            //    using (IDataReader rdr4 = DB2Connect.DBHelper.ExecuteReader(sql))
                            //    {
                            //        while (rdr4.Read())
                            //        {
                            //            if (rdr4["num"] != DBNull.Value)
                            //                theArea.Parking_STATUS = Convert.ToInt32(rdr4["num"]);
                            //        }
                            //    }
                            //    if (theArea.Parking_STATUS == 5)
                            //    {
                            //        try
                            //        {
                            //            sql = @"update UACS_YARDMAP_AREA_DEFINE set X_START =80000, X_END =81000,Y_START =80000, Y_END =81000 WHERE AREA_NO in ('TRAINCAP1','TRAINCAP2','TRAINCAP3')";

                            //            DB2Connect.DBHelper.ExecuteNonQuery(sql);
                            //        }
                            //        catch (Exception er)
                            //        {

                            //        }

                            //    }
                            //    else
                            //    {
                            //        try
                            //        {
                            //            sql = @"update UACS_YARDMAP_AREA_DEFINE set X_START =29000, X_END =41500,Y_START =500, Y_END =3400 WHERE AREA_NO='TRAINCAP1'";

                            //            DB2Connect.DBHelper.ExecuteNonQuery(sql);
                            //        }
                            //        catch (Exception er)
                            //        {

                            //        }
                            //        try
                            //        {
                            //            sql = @"update UACS_YARDMAP_AREA_DEFINE set X_START =41500, X_END =54500,Y_START =500, Y_END =3400 WHERE AREA_NO='TRAINCAP2'";

                            //            DB2Connect.DBHelper.ExecuteNonQuery(sql);
                            //        }
                            //        catch (Exception er)
                            //        {

                            //        }
                            //        try
                            //        {
                            //            sql = @"update UACS_YARDMAP_AREA_DEFINE set X_START =54450, X_END =66950,Y_START =500, Y_END =3400 WHERE AREA_NO='TRAINCAP3'";

                            //            DB2Connect.DBHelper.ExecuteNonQuery(sql);
                            //        }
                            //        catch (Exception er)
                            //        {

                            //        }
                            //    }
                            #endregion
                            dicSaddles[theArea.AreaNo] = theArea;
                        }                     
                    }
                }
            }
            catch (Exception er)
            {
                
                throw;
            }         
        }
        /// <summary>
        /// 查找部分钢坯数据(钢坯数据)
        /// </summary>
        public void getPortionAreaData1()
        {
            string sql = null;
            try
            {
                // 标记用于区分小区类别
                sql = "select * from UACS_YARDMAP_COIL";
                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {                    
                            AreaInfo areainfo = new AreaInfo ();
                            if (rdr["COIL_NO"] != System.DBNull.Value)
                            {
                                areainfo.COIL_NO = Convert.ToString(rdr["COIL_NO"]);
                            }                                                 
                                //theArea.TBayNO = theArea.AreaNo.Substring(0, 3);

                                //theArea.TAreaNo = theArea.AreaNo.Substring(6, theArea.AreaNo.Count() - 6);

                                //StringBuilder sbTagName_Safe = new StringBuilder("AREA_SAFE_");
                                //sbTagName_Safe.Append(theArea.TBayNO);
                                //sbTagName_Safe.Append("_");
                                //sbTagName_Safe.Append(theArea.TAreaNo);

                                //theArea.AreaDoorSefeName = sbTagName_Safe.ToString();

                                //StringBuilder sbTagName_Reserve = new StringBuilder("AREA_RESERVE_");
                                //sbTagName_Reserve.Append(theArea.TBayNO);
                                //sbTagName_Reserve.Append("_");
                                //sbTagName_Reserve.Append(theArea.TAreaNo);
                                //theArea.AreaDoorReserveName = sbTagName_Reserve.ToString();                   
                          //  dicSaddles[theArea.COIL_NO] = theArea;
                        }
                   
                }
            }
            catch (Exception er)
            {

                throw;
            }

        }


        private string[] arrTagAdress;
        /// <summary>
        /// 存储所有tag点的地址
        /// </summary>
        public void getTagNameList()
        {
            try
            {
                List<string> TagNamelist = new List<string>();
                
                foreach (AreaBase item in dicSaddles.Values)
                {
                    if (item.AreaType == 7||item .AreaType ==8)
                    {

                     //   TagNamelist.Add(item.AreaDoorReserveName);
                     //   TagNamelist.Add(item.AreaDoorSefeName);
                        //红一区
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_AREA1);
                        //红二区
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_AREA2);
                        //红三区.
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_AREA3);
                        //安全门1
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_DOOR1);
                        //安全门2
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_DOOR2);
                        //安全门3
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_DOOR3);
                        //安全门4
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_DOOR4);
                        //安全门5
                        TagNamelist.Add(AreaInfo.ADRESS_SAFE_DOOR5);
                    }

                }

                arrTagAdress = TagNamelist.ToArray<string>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// tag点值的map
        /// </summary>
        Baosight.iSuperframe.TagService.DataCollection<object> inDatas = new Baosight.iSuperframe.TagService.DataCollection<object>();

        /// <summary>
        /// 遍历tag点获取值
        /// </summary>
        public void getTagValues()
        {
            try
            {
                //清空原来的map
                inDatas.Clear();
                //读所有鞍座tag点的值
              
                tagDataProvider.GetData(arrTagAdress, out inDatas);

                //为每个鞍座的tag点值属性赋值
                foreach (AreaBase item in dicSaddles.Values)
                {
                    if (item.AreaType == 8)
                    {
                      //  item.AreaDoorSefeValue = get_value_x(item.AreaDoorSefeName);
                     //   item.AreaDoorReserveValue = get_value_x(item.AreaDoorReserveName);
                        //红一区
                        item.SAFE_AREA_1_Value = get_value_x(AreaInfo.ADRESS_SAFE_AREA1);
                        //红二区
                       item.SAFE_AREA_2_Value= get_value_x(AreaInfo.ADRESS_SAFE_AREA2);
                        //红三区
                       item.SAFE_AREA_3_Value= get_value_x(AreaInfo.ADRESS_SAFE_AREA3);

                    }
                    else if(item.AreaType == 7)
                    {
                        item.Safe_door1 = get_value_x(AreaInfo.ADRESS_SAFE_DOOR1);
                        item.Safe_door2 = get_value_x(AreaInfo.ADRESS_SAFE_DOOR2);
                        item.Safe_door3 = get_value_x(AreaInfo.ADRESS_SAFE_DOOR3);
                        item.Safe_door4 = get_value_x(AreaInfo.ADRESS_SAFE_DOOR4);
                        item.Safe_door5 = get_value_x(AreaInfo.ADRESS_SAFE_DOOR5);
     

                    }

                }
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 根据tag返回一个值
        /// </summary>
        /// <param name="tagName">tag名称</param>
        /// <returns></returns>
        private long get_value_x(string tagName)
        {
            long theValue = 2;
            object valueObject = null;
            try
            {
                valueObject = inDatas[tagName];
                theValue = Convert.ToInt32(valueObject);
            }
            catch
            {
                valueObject = null;
            }
            return theValue;
        }

        /// <summary>
        /// 读小区全部鞍座数量
        /// </summary>
        /// <param name="_AreaNo"></param>
        /// <returns></returns>
        public int getAreaSaddleNum(string _AreaNo)
        {
            int saddlenum = 0;
            try
            {
                string sql= string.Empty;
                //查询所有有鞍座坐标的鞍座数量
                sql = @"SELECT COUNT(*) as num FROM UACS_YARDMAP_STOCK_DEFINE A left join UACS_YARDMAP_SADDLE_STOCK B on A.STOCK_NO = B.STOCK_NO  
                            left join UACS_YARDMAP_SADDLE_DEFINE C on B.SADDLE_NO = C.SADDLE_NO 
                            LEFT JOIN UACS_YARDMAP_ROWCOL_DEFINE D ON D.COL_ROW_NO = C.COL_ROW_NO
                            WHERE D.AREA_NO like '" + _AreaNo + "%' and C.X_CENTER > 0 ";                           
                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        if (rdr["num"] != DBNull.Value)
                            saddlenum = Convert.ToInt32(rdr["num"]);
                    }
                }
            }
            catch (Exception er)
            {
                return 0;
            }
            return saddlenum;
        }

        /// <summary>
        /// 读小区白库位数量
        /// </summary>
        /// <param name="_AreaNo"></param>
        /// <returns></returns>
        public int getAreaSaddleNoCoilNum(string _AreaNo)
        {
            int saddleNoCoil = 0;
            try
            {
                string sql = string.Empty;
                sql = @"SELECT  COUNT(*) as num FROM UACS_YARDMAP_STOCK_DEFINE A left join UACS_YARDMAP_SADDLE_STOCK B on A.STOCK_NO = B.STOCK_NO  
                            left join UACS_YARDMAP_SADDLE_DEFINE C on B.SADDLE_NO = C.SADDLE_NO 
                             LEFT JOIN UACS_YARDMAP_ROWCOL_DEFINE D ON D.COL_ROW_NO = C.COL_ROW_NO
                            WHERE D.AREA_NO like '" + _AreaNo + "%' and C.X_CENTER > 0 AND A.STOCK_STATUS = 0 AND A.LOCK_FLAG = 0";
                    
                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        if (rdr["num"] != DBNull.Value)
                            saddleNoCoil = Convert.ToInt32(rdr["num"]);
                    }
                }
            }
            catch (Exception er)
            {
                return 0;
            }
            return saddleNoCoil;
        }

        /// <summary>
        /// 读小区黑库位数量
        /// </summary>
        /// <param name="_AreaNo"></param>
        /// <returns></returns>
        public int getAreaSaddleCoilNum(string _AreaNo)
        {
            int saddleCoil = 0;
            try
            {
                string sql = string.Empty;
                sql = @"SELECT  COUNT(*) as num FROM UACS_YARDMAP_STOCK_DEFINE A left join UACS_YARDMAP_SADDLE_STOCK B on A.STOCK_NO = B.STOCK_NO  
                            left join UACS_YARDMAP_SADDLE_DEFINE C on B.SADDLE_NO = C.SADDLE_NO 
                             LEFT JOIN UACS_YARDMAP_ROWCOL_DEFINE D ON D.COL_ROW_NO = C.COL_ROW_NO
                            WHERE D.AREA_NO like '" + _AreaNo + "%' and C.X_CENTER > 0 AND  A.STOCK_STATUS = 2 AND A.LOCK_FLAG = 0";

                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        if (rdr["num"] != DBNull.Value)
                            saddleCoil = Convert.ToInt32(rdr["num"]);
                    }
                }
            }
            catch (Exception er)
            {
                return 0;
            }
            return saddleCoil;
        }
        //public void getnum()
        //{
        //    try
        //    {
        //        string sql = string.Empty;

        //        //查询所有有鞍座坐标的鞍座数量
        //        sql = @"SELECT B.STOCK_STATUS as num FROM UACS_YARDMAP_AREA_DEFINE A left join UACS_YARDMAP_TRAIN_STOCK_DEFINE B on A.AREA_TYPE = B.STOCK_TYPE
        //                    WHERE A.AREA_NAME = '" + AreaName + "' and A.AREA_TYPE = 5 ";
        //        using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
        //        {
        //            while (rdr.Read())
        //            {
                      
        //                if (rdr["num"] != DBNull.Value)

        //                   theArea.STOCK_STATUS = rdr["num"].ToString();
                       

        //            }
        //        }

        //    }
        //    catch (Exception er)
        //    {

        //        throw;
        //    }


        //}
    }
}
