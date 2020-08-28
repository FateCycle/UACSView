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
            /// 卡车
            /// </summary>
            CarArea,
            /// <summary>
            /// 除了库区不显示其他都显示
            /// </summary>
            NoStockAndRestsType
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

        /// <summary>
        /// 查找部分对应数据(不包括小区)
        /// </summary>
        public void getPortionAreaData()
        {

            string sql = null;

            try
            {
                // 标记用于区分小区类别
                sql = "SELECT AREA_NO,X_START,X_END,Y_START,Y_END,AREA_TYPE,AREA_NAME FROM UACS_YARDMAP_AREA_DEFINE";

                if (areaTypeS == AreaType.CarArea)
                {
                    sql += " WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE = 1";
                }
                else if (areaTypeS == AreaType.StockArea)
                {
                    sql += " WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE = 0";
                }
                else if (areaTypeS == AreaType.UnitArea)
                {
                    sql +=" WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE in (4,5)";  //机组出入口
                }
                else if (areaTypeS == AreaType.NoStockAndRestsType)
                {
                    sql += " WHERE BAY_NO LIKE '"+bayNo+"%'  and AREA_TYPE != 0";
                }
                else
                {
                    sql += " WHERE BAY_NO LIKE '" + bayNo + "%' ";
                }

                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        if (rdr["AREA_NO"] != System.DBNull.Value)
                        {
                            AreaBase theArea = new AreaBase();
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

                            if (theArea.AreaType == 0)
                            {
                                theArea.AreaSaddleNum = getAreaSaddleNum(theArea.AreaNo);

                                theArea.AreaSaddleNoCoilNum = getAreaSaddleNoCoilNum(theArea.AreaNo);

                                theArea.AreaSaddleCoilNum = getAreaSaddleCoilNum(theArea.AreaNo);

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

                            }

                          

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
                    if (item.AreaType == 0)
                    {
                        TagNamelist.Add(item.AreaDoorReserveName);
                        TagNamelist.Add(item.AreaDoorSefeName);
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
                    if (item.AreaType == 0)
                    {
                        item.AreaDoorSefeValue = get_value_x(item.AreaDoorSefeName);
                        item.AreaDoorReserveValue = get_value_x(item.AreaDoorReserveName);
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
            long theValue = 0;
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
    }
}
