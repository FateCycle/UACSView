using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL.CraneMonitor
{
    public class TCraneAlarmJudge
    {
        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDataProvider = new Baosight.iSuperframe.TagService.Controls.TagDataProvider();

        Baosight.iSuperframe.TagService.DataCollection<object> inDatas = new Baosight.iSuperframe.TagService.DataCollection<object>();

        private string[] arrTagAdress;

        private string crane_No = null;

        private string TagName = null;


        //  报警代码和注释
        IList<TCraneAlarm> listCraneAlarm = new List<TCraneAlarm>();

        /// <summary>
        /// 行车号
        /// </summary>
        public string Crane_No
        {
            get { return crane_No; }
            set
            {
                crane_No = value;
            }
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        private static Baosight.iSuperframe.Common.IDBHelper dbHelper = null;

        private static Baosight.iSuperframe.Common.IDBHelper DBHelper
        {
            get
            {
                if (dbHelper == null)
                {
                    try
                    {
                        dbHelper = Baosight.iSuperframe.Common.DataBase.DBFactory.GetHelper("localAPP");
                    }
                    catch (System.Exception e)
                    {
                        //throw e;
                    }

                }
                return dbHelper;
            }
        }

        public void InitTagDataProvide(string tagServiceName)
        {
            try
            {
                tagDataProvider.ServiceName = tagServiceName;
            }
            catch (Exception ex)
            {
            }
        }

        public bool isAlarm()
        {
            if (Crane_No != null)
            {
                tagDataProvider.ServiceName = "iplature";
                TagName = Crane_No + "_ALARM_CURRENT";
                SetReady(TagName);
                readTags();

                string value = get_value_string(TagName);


                if (value == null)
                {
                    return false;
                }
                string[] sArray = value.Split(',');
                foreach (string i in sArray)
                {
                    string dd = i;
                    if (dd == " " || dd == null || dd == "" || dd == "undefined")
                    {
                        dd = "0";

                    }
                    int code = Convert.ToInt32(dd.ToString());
                    // 非零出现故障
                    if (code != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }




        #region read tag

        public void SetReady(string tagName)
        {
            try
            {
                List<string> lstAdress = new List<string>();
                lstAdress.Add(tagName);
                arrTagAdress = lstAdress.ToArray<string>();
            }
            catch (Exception er)
            {

            }
        }

        private void readTags()
        {
            try
            {
                inDatas.Clear();
                tagDataProvider.GetData(arrTagAdress, out inDatas);
            }
            catch (Exception ex)
            {
            }
        }

        private string get_value_string(string tagName)
        {
            string theValue = string.Empty;
            object valueObject = null;
            try
            {
                valueObject = inDatas[tagName];
                theValue = Convert.ToString((valueObject));
            }
            catch
            {
                valueObject = null;
            }
            return theValue; ;
        }
        #endregion
    }
}
