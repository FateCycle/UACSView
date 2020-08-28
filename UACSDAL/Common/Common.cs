using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using IBM.Data.DB2;
using UACSDAL.Common;
using UACSDAL;

namespace UACSDAL.Common
{
    public class Common
    {
        public static string strConn;
        string iPlaturePath;
        public string IPlaturePath
        {
            get { return iPlaturePath = Environment.GetEnvironmentVariable("IPLATURE"); }
        }

        string sF_HOMECfgPath;
        public string SF_HOMECfgPath
        {
            get { iPlaturePath = Environment.GetEnvironmentVariable("IPLATURE"); sF_HOMECfgPath = iPlaturePath + @"SF_HOME\config\"; return sF_HOMECfgPath; }
        }

        ///将字符串分隔成数组。分隔符“|”。
        static public string[] Split(string strIn, bool ignoreNull)
        {
            string[] strOut;
            if (ignoreNull)
                strOut = strIn.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            else
                strOut = strIn.Split(new char[] { '|' });
            return strOut;
        }

        ///将字符串分隔成数组。
        static public string[] Split(string strIn, bool ignoreNull, char splitChar)
        {
            string[] strOut;
            if (ignoreNull)
                strOut = strIn.Split(new char[] { splitChar }, StringSplitOptions.RemoveEmptyEntries);
            else
                strOut = strIn.Split(new char[] { splitChar });
            return strOut;
        }

        static public string GetLineAreasFromXmlKey(string key)
        {
            string configFullName = Environment.GetEnvironmentVariable("IPLATURE") + constData.Path_GlobalInfo;
            string str = XmlHelper.Read(configFullName, string.Format("configuration/FormsList/form[@name='{0}']", key), "lineAreas");
            return str;
        }

        ///从全局配置文件中获得连接字符串
        static public string GetStrConn(string name)
        {
            string strconn = XmlHelper.Read(constData.Path_GlobalInfo, string.Format("configuration/GloblaSetting/ConnectString/add[@key='{0}']", name), "value");
            strConn = strconn;
            return strconn;
        }

        public static string GetConnString(string strName)
        {
            string configFullName = Environment.GetEnvironmentVariable("IPLATURE") + @"SF_HOME\config\SuperFrame.config";
            string strconn = XmlHelper.Read(configFullName, string.Format("configuration/dbConfiguration/Dbs/add[@name='{0}']", strName), "connectionString");
            strConn = strconn;
            return strconn;
        }

        static public string GetSqlTxt(string sqlPath,string sqlCmdName,params string[] parameters)
        {
            string sqlFullTxt = String.Empty;
            try
            {
                string configFullName = Environment.GetEnvironmentVariable("IPLATURE") + sqlPath;
                string strSqlTxt = XmlHelper.Read(configFullName, string.Format("configuration/SqlCmd[@name='{0}']/CmdText", sqlCmdName), "");
                sqlFullTxt = string.Format(strSqlTxt, parameters);
                sqlFullTxt = sqlFullTxt.Trim(new char[] { '\r', '\n', ' ' });
            }
            catch (Exception)
            {
            }
            return sqlFullTxt;
        }

        static public DataTable GetDataRecords(string sqlPath, string sqlCmdName, params string[] parameters)
        {
            DBRecordsUnit u = new IBMRecordsUnit();
            if(Common.strConn ==null || Common.strConn.Trim()!= String.Empty)
                strConn = GetConnString(constData.DBName);
            u.StrConn = strConn;
            u.strCmdText = GetSqlTxt(sqlPath, sqlCmdName, parameters);
            u.PrepareAdapter();
            u.FillDTRecords();
            return u.dt;
        }

        static public string GetGlobalFilePath()
        {
            string configFullName = Environment.GetEnvironmentVariable("IPLATURE") + constData.Path_GlobalInfo;
            return configFullName;
        }

        static public string GetLineOpenForm(string name)
        {
            string configFullName = Environment.GetEnvironmentVariable("IPLATURE") + constData.Path_GlobalInfo;
            string str = XmlHelper.Read(configFullName, string.Format("configuration/GloblaSetting/LineSaddle[@AreaNO='{0}']", name), "OpenForm");
            return str;
        }

        static public DataTable GetPlatDataRecords(string sqlPath, string sqlCmdName, params string[] parameters)
        {
            DBRecordsUnit u = new IBMRecordsUnit();
            if (Common.strConn == null || Common.strConn.Trim() != String.Empty)
                strConn = GetConnString(constData.PlatDBName);
            u.StrConn = strConn;
            u.strCmdText = GetSqlTxt(sqlPath, sqlCmdName, parameters);
            u.PrepareAdapter();
            u.FillDTRecords();
            return u.dt;
        }

        static public int ExeSqlCmd(string sqlTxt)
        {
            int iResult = 0;
            DB2Connection cn = new DB2Connection();

            try
            {
                if (Common.strConn == null || Common.strConn.Trim() != String.Empty)
                    strConn = GetConnString(constData.DBName);
                cn = new DB2Connection(strConn);
                DB2Command cmd = new DB2Command(sqlTxt, cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                iResult = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return iResult;
        }
        static public DB2DataReader ExecteReader(string sqlTxt)
        {
            DB2Connection cn = new DB2Connection();

            if (Common.strConn == null || Common.strConn.Trim() != String.Empty)
                strConn = GetConnString(constData.DBName);
            cn = new DB2Connection(strConn);
            DB2Command cmd = new DB2Command(sqlTxt, cn);
            if (!cn.IsOpen)
                cn.Open();

            DB2DataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public static IList<T> BindingDaTable2Entitys<T>(DataTable dt)
        {
            IList<T> TList = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                T item = BindingData2Entity<T>(dt, i);
                TList.Add(item);
            }
            return TList;
        }

        public static T BindingData2Entity<T>(DataTable dt, int irow)
        {
            T item = Activator.CreateInstance<T>();
            Type t = typeof(T);
            foreach (PropertyInfo property in t.GetProperties())
            {
                if (!dt.Columns.Contains(property.Name) || dt.Rows[irow][property.Name] == null || dt.Rows[irow][property.Name] == DBNull.Value)
                    continue;
                property.SetValue(item, dt.Rows[irow][property.Name], null);
            }
            return item;
        }
    }
}
