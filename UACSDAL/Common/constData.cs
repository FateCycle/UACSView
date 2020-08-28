using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL.Common
{
    public class constData
    {
        /// <summary>
        /// 平台名称
        /// </summary>
        public const string tagServiceName = "iplature";

        /// <summary>
        /// 机组入口定义
        /// </summary>
        public const int EntrySaddleDefine = 0;
     
        /// <summary>
        /// 机组出口定义
        /// </summary>
        public const int ExitSaddleDefine = 1;

        /// <summary>
        /// 机组号
        /// </summary>
        public const string UnitNo = "MC1";

        public const string bayNo = "B";

        public const long Z2250BaySpaceX = 125000;
        public const long Z2250BaySpaceY = 25000;

        public const long Z11_Z12BaySpaceX = 125000;
        public const long Z11_Z12BaySpaceY = 25000;

        public const bool xAxisRight = false;
        public const bool yAxisDown = false;






        public const string DBName = "UACSAPP";
        public const string PlatDBName = "AUTH11";
        //public const string DBName = "C02APP";
        //public const string PlatDBName = "C02AUTH";
        public const string TagServiceName = "iplature";
        public const string Path_GlobalInfo = @"SF_HOME\config\GlobalCfg.xml";
        public const string Path_sqlSysManage = @"SF_HOME\config\sqlSysManage.xml";
        public const string Path_sqlYardManage = @"SF_HOME\config\sqlYardManage.xml";
        public const string Path_sqlJobOrder = @"SF_HOME\config\sqlJobOrder.xml";
        public const string Path_sqlDeviceManage = @"SF_HOME\config\sqlDeviceManage.xml";
        public const string Path_sqlStatisticAnalysis = @"SF_HOME\config\sqlStatisticAnalysis.xml";
        public const string Path_sqlParkingStatus = @"SF_HOME\config\sqlParkingStatus.xml";
        public const string Path_sqlGenerator = @"SF_HOME\config\sqlGenerator.xml";
        public const string Path_sqlYardmapParkingsite = @"SF_HOME\config\sqlYardmapParkingsite.xml";
        public const string Path_sqlTruckStowageDetail = @"SF_HOME\config\sqlTruckStowageDetail.xml";
        public const string Path_sqlYardMapCoil = @"SF_HOME\config\sqlYardMapCoil.xml";
        public const string Path_sqlCraneOrderZ32Z33 = @"SF_HOME\config\sqlCraneOrderZ32Z33.xml";
        public const string Path_sqlTruckFrameDefine = @"SF_HOME\config\sqlTruckFrameDefine.xml";
        public const string Path_sqlShipmentBound = @"SF_HOME\config\sqlShipmentBound.xml";
        public const string Path_sqlYardmapCrane = @"SF_HOME\config\sqlYardmapCrane.xml";
        public const string Path_sqlSysLogMessage = @"SF_HOME\config\sqlSysLogMessage.xml";
        public const string Path_sqlLineManage = @"SF_HOME\config\sqlLineManage.xml";
        public const string Path_sqlStatisics = @"SF_HOME\config\sqlStatisics.xml";
        public const string Path_sqlGetPlan = @"SF_HOME\config\sqlGetPlan.xml";
        public const string Path_sqlSrsManager = @"SF_HOME\config\sqlSrsManager.xml";
        public const string sqlGetLineInfo1 = "GetLineInfo1";
        #region 库区管理
        public const string sqlGetAllBayInf = "GetAllBayInf";
        public const string sqlGetBayInfByID = "GetBayInfByID";
        public const string sqlGetBayInfByYard = "GetBayInfByYard";
        public const string sqlGetTargetBaysInfByID = "GetTargetBaysInfByID";

        public const string sqlGetAreasByBay = "GetAreasByBay";
        public const string sqlGetAreaInfByID = "GetAreaInfByID";
        public const string sqlGetAreaInfByBay = "GetAreaInfByBay";
        public const string sqlGetAllAreaInfInBay = "GetAllAreaInfInBay";

        public const string sqlGetRowColByArea = "GetRowColByArea";
        public const string sqlGetRowColByBay = "GetRowColByBay";

        public const string sqlGetSaddleByArea = "GetSaddleByArea";
        public const string sqlGetSaddleByArea0 = "GetSaddleByArea0";
        public const string sqlGetStockInfBySaddleID = "GetStockInfBySaddleID";
        public const string sqlGetLineStockInfByStockNO = "GetLineStockInfByStockNO";
        public const string sqlGetStockInfByStockNo = "GetStockInfByStockNo";
        public const string sqlStaticSaddleByArea = "StaticSaddleByArea";

        public const string sqlGetChannelsByYard = "GetChannelsByYard";
        public const string sqlGetChannelsByBay = "GetChannelsByBay";
        public const string sqlGetTargetChannelsInfByID = "GetTargetChannelsInfByID";
        public const string sqlGetParkingSitesByYard = "GetParkingSitesByYard";
        public const string sqlGetTargetParkingSitesInfByID = "GetTargetParkingSitesInfByID";
        public const string sqlGetTargetParkingSitesInfByAreas = "GetTargetParkingSitesInfByAreas";
        public const string sqlGetTargetParkingSitesInfByChannels = "GetTargetParkingSitesInfByChannels";

        public const string sqlGetStockByBay = "GetStockByBay";
        public const string sqlGetStockInfo = "GetStockInfo";
        public const string sqlGetSecurityDoorByBay = "GetSecurityDoorByBay";
        public const string sqlGetTrafficLightByBay = "GetTrafficLightByBay";

        public const string sqlGetCoilByArea = "GetCoilByArea";
        public const string sqlGetCoilByCoilNo = "GetCoilByCoilNo";
        public const string sqlGetCoilByBay = "GetCoilByBay";
        public const string sqlGetCoilByRowCol = "GetCoilByRowCol";
        public const string sqlUpdateCoilByCoilNo = "UpdateCoilByCoilNo";
        public const string sqlDeleteCoilByCoilNo = "DeleteCoilByCoilNo";
        public const string sqlUpdateCoilInStockByStockNo = "UpdateCoilInStockByStockNo";

        public const string sqlGetCraneByBay = "GetCraneByBay";
        public const string sqlGetInfOfAllCrane = "GetInfOfAllCrane";

        public const string sqlAddCoil = "AddCoil";

        public const string sqlGetCoilStock = "GetCoilStock";
        public const string sqlAddArea = "AddArea";
        public const string sqlAddRowCol = "AddRowCol";
        public const string sqlAddSaddle = "AddSaddle";
        public const string sqlAddStock = "AddStock";
        public const string sqlDelRowColByColRowNo = "DelRowColByColRowNo";
        public const string sqlDelSaddleByColRowNo = "DelSaddleByColRowNo";
        public const string sqlGetRowColByColRowNo = "GetRowColByColRowNo";

        public const string sqlDelAreaByAreaNo = "DelAreaByAreaNo";
        public const string sqlDelRowColByAreaNo = "DelRowColByAreaNo";
        public const string sqlDelSaddleByAreaNo = "DelSaddleByAreaNo";
        public const string sqlDelTempStock = "DelTempStock";

        public const string sqlSelectArea = "SelectArea";
        public const string sqlSelectRowCol = "SelectRowCol";
        public const string sqlSelectSaddle = "SelectSaddle";
        public const string sqlSelectStock = "SelectStock";

        public const string sqlDeleteArea = "DeleteArea";
        public const string sqlDeleteRowCol = "DeleteRowCol";
        public const string sqlDeleteSaddle = "DeleteSaddle";
        public const string sqlDeleteStock = "DeleteStock";

        #endregion

        #region 系统管理
        public const string sqlGetRuleIdByid = "GetRuleIdByid";         //根据ID获取权限ID
        public const string sqlGetMsgLevel = "GetMsgLevel";             //获得所有信息等级
        public const string sqlGetMsgModule = "GetMsgModule";           //获取所有信息模块
        public const string sqlGetAlarmMsg = "GetAlarmMsg";             //获取日志信息
        public const string sqlGetAlarmMsgCrane = "GetAlarmMsgCrane";

        public const string sqlUpdateConfirmOfAlarm = "UpdateConfirmOfAlarm";       //更新日志信息确认人

        public const string sqlGetCraneAlarmInfo = "GetCraneAlarmInfo";

        public const string sqlGetMsgTrolley = "GetMsgTrolley";        //获取台车监控信息
        public const string sqlGetTrolleyNum = "GetTrolleyNum";         //获取台车数量
        public const string sqlGetTrolleyStatus = "GetTrolleyStatus";   //获取台车状态
        public const string sqlGetCoilInfoOnTrolley = "GetCoilInfoOnTrolley"; //获取台车钢卷信息
        public const string sqlGetShipmentBound = "GetShipmentBound";  //获取发货绑定信息
        public const string sqlINSERTShipmentBound = "INSERTShipmentBound"; //发货绑定信息存入数据库
        public const string sqlDELETEShipmentBound = "DELETEShipmentBound"; //解除绑定
        public const string sqlGetPickNo = "GetPickNo";             //获取提单号

        #endregion

        //机组信息
        public const string sqlGetLineInfo = "GetLineInfo";
        public const string sqlGetPackageInfo = "GetPackageInfo";
        public const string sqlGetEntryActor = "GetEntryActor";
        public const string sqlUpdateEntryActor = "UpdateEntryActor";
        public const string sqlGetPickPlanOnTime = "GetPickPlanOnTime";
        public const string sqlGetTransPlanOnTime = "GetTransPlanOnTime";
        public const string sqlUpdateEnable = "UpdateEnable";
        public const string sqlUpdateOpenDirection = "UpdateOpenDirection";
        public const string sqlGetPackHmiStatus = "GetPackHmiStatus";
        public const string sqlUpdatePackHmiStatus = "UpdatePackHmiStatus";
        public const string sqlGetNextCoilNo = "GetNextCoilNo";





        public const string sqlUpdateEntryStatus = "UpdateEntryStatus";
        public const string sqlUpdateLineStatus = "UpdateLineStatus";
        public const string sqlUPdateCheck = "UpdateLineCheck";
        //sqlJobOrder
        public const string sqlGetCraneByOrderNo = "GetCraneByOrderNo";
        public const string sqlGetAllCraneJobType = "GetAllCraneJobType";//行车所有作业类型


        public const string sqlGetCoilByStockNo = "GetCoilByStockNo";
        public const string sqlGetAllParkingStatus = "GetAllParkingStatus";

        public const string sqlGetTableName = "GetTableName";
        public const string sqlGetColName = "GetColName";
        public const string sqlGetAllParkingsite = "GetAllParkingsite";

        public const string sqlGetParkingStatusById = "GetParkingStatusById";
        public const string sqlGetTruckStowageDetailById = "GetTruckStowageDetailById";
        public const string sqlGetAllYardMapCoil = "GetAllYardMapCoil";
        public const string sqlGetYardMapCoilByID = "GetYardMapCoilByID";
        public const string sqlGetCraneOrderZ32Z33ByID = "GetCraneOrderZ32Z33ByID";
        public const string sqlGetAllTruckFrameDefine = "GetAllTruckFrameDefine";
        public const string sqlGetTruckFrameDefineByFrameTypeNo = "GetTruckFrameDefineByFrameTypeNo";
        public const string sqlGetYardmapCraneByName = "GetYardmapCraneByName";
        public const string sqlGetAllYardmapCrane = "GetAllYardmapCrane";

        public const string sqlGetSaddleByRow = "GetSaddleByRow";
        public const string sqlGetStockColInfo = "GetStockColInfo";
        public const string sqlGetStockRowInfo = "GetStockRowInfo";
        public const string sqlGetStockStatus = "GetStockStatus";
        public const string sqlGetCoilStockInfo = "GetCoilStockInfo";
        public const string sqlGetCoilInfo = "GetCoilInfo";
        public const string sqlGetCoilInfoInStock = "GetCoilInfoInStock";
        public const string sqlUpdateStockStatus = "UpdateStockStatus";
        public const string sqlUpdatePackStock = "UpdatePackStock";
        public const string sqlInsertAlterStockOper = "InsertAlterStockOper";
        public const string sqlUpdateSaddleStatus = "UpdateSaddleStatus";
        public const string sqlUpdateOpenDirectionAlter = "UpdateOpenDirectionAlter";
        public const string sqlUpdatePackStatus = "UpdatePackStatus";
        public const string sqlGetStockEnable = "GetStockEnable";
        public const string sqlGetStockDisable = "GetStockDisable";
        public const string sqlGetStockJudge = "GetStockJudge";
        public const string sqlGetAlterStock = "GetAlterStock";


        public const string sqlStatisticSaddleNum = "StatisticSaddleNum";

        #region 日志管理

        public const string sqlGetSaddleLog = "GetSaddleLog";   //按时间查找全部类型日志
        public const string sqlGetSaddleLogType = "GetSaddleLogByType"; //按时间类型查找日志
        public const string sqlGetSaddleLogByTypeAndNo = "GetSaddleLogByTypeAndNo"; //按时间类型鞍座号查找日志
        public const string sqlGetSaddleLogByNo = "GetSaddleLogByNo"; //按时间鞍座号查找日志
        public const string sqlGetJobType = "GetJobType";  //获取工作类型
        public const string sqlGetSaddleNo = "GetSaddleNo";  //获取鞍座号
        public const string sqlGetMatOperLogByMatNo = "GetMatOperLogByMatNo"; //按材料号获取材料操作信息
        public const string sqlGetMatOperLogByAll = "GetMatOperLogByAll"; //获取材料操作信息
        public const string sqlGetCraneOperHisyByAll = "GetCraneOperHisyByAll";  //获取全部行车操作历史信息
        public const string sqlGetCraneOperHisyByType = "GetCraneOperHisyByType";  //按类型获取全部行车操作历史信息
        public const string sqlGetCraneOperHisyByTandC = "GetCraneOperHisyByTandC"; //按类型和行车获取行车操作历史信息
        public const string sqlGetCraneOperHisyByCraneNo = "GetCraneOperHisyByCraneNo"; //按行车获取行车操作历史信息
        public const string sqlGetCraneNo = "GetCraneNo";            //获取行车号
        public const string sqlGetCraneOperType = "CraneOperType";     //获取操作类型
        public const string sqlGetCraneWorkLog = "GetCraneWorkLog";     //获取全部行车工作日志
        public const string sqlGetCraneWorkType = "GetCraneWorkType";       //获取行车全部工作类型
        public const string sqlGetPlanData = "GetPlanData";
        public const string sqlGetPlanType = "GetPlanType";
        public const string sqlGetPlanMat = "GetPlanMat";
        public const string sqlGetPlanNum = "GetPlanNum";
        public const string sqlGetPlanItemCount = "GetPlanItemCount";
        #endregion

        #region 指令管理

        public const string sqlGetOrderQueueByNO = "GetOrderQueueByNO";
        public const string sqlGetOrderQueueByNOClts = "GetOrderQueueByNOClts";
        public const string sqlGetOrderQueueByNOAvoid = "GetOrderQueueByNOAvoid";
        public const string sqlGetCraneCurOrderNo = "GetCraneCurOrderNo";
        public const string sqlGetOrderQueue = "GetOrderQueue";
        public const string sqlDelOrderQueue = "DelOrderQueue";
        public const string sqlUpdOrderQueue = "UpdOrderQueue";
        public const string sqlGetOrderDownData = "GetOrderDownData";
        public const string sqlGetOrderOperData = "GetOrderOperData";
        #endregion


        public const string sqlGetSrsCarInfo = "GetSrsCarInfo";
        public const string sqlGetTruckInMatInfo = "GetTruckInMatInfo";
        public const string sqlGetSrsInInfo = "GetSrsInInfo";
        public const string sqlGetSrsOutInfo = "GetSrsOutInfo";
        public const string sqlGetSrsParkingNo = "GetSrsParkingNo";
        public const string sqlGetTruckPlanInfo = "GetTruckPlanInfo";
        public const string sqlGetTruckOutMatInfo = "GetTruckOutMatInfo";
        public const string sqlGetCarPickInfo = "GetCarPickInfo";
        public const string sqlGetCarOutSrsInfo = "GetCarOutSrsInfo";
        public const string sqlGetCarMatSelect = "GetCarMatSelect";
        public const string sqlGetCraneModeNum = "GetCraneModeNum";

        public const string sqlGetL2Plan = "GetL2Plan";
        public const string sqlDeleteL3PlanNo = "DeleteL3PlanNo";
        public const string sqlGetAlterL2Plan = "GetAlterL2Plan";
        public const string sqlGetAlterL2PlanA = "GetAlterL2PlanA";
        public const string sqlGetTruckPlanMatInfo = "GetTruckPlanMatInfo";
    }
}
