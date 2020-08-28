using System;
using System.Collections.Generic;
using System.Linq;
using IBM.Data.DB2;
using System.Data;
using System.Text;

namespace UACSDAL.Common
{
    public class DBRecordsUnit
    {
        internal string strConn;
        public string StrConn
        {
            get { return strConn; }
            set { strConn = value; }
        }

        internal string strCmdText;
        public string StrCmdText
        {
            get { return strCmdText; }
            set { strCmdText = value; }
        }

        internal DataTable dtRecords = new DataTable();
        public DataTable dt
        {
            get { return dtRecords; }
            set { dtRecords = value; }
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public virtual void CloseConnection()
        {
        }

        //=======================================



        //=======================================
        /// <summary>
        /// 填充数据至DataTable——dtRecords中
        /// </summary>
        public virtual void FillDTRecords()
        {
        }

        /// <summary>
        /// 更新所有变更
        /// </summary>
        public virtual void SaveChanges()
        {
        }

        /// <summary>
        /// 更新适配器数据
        /// </summary>
        public virtual void PrepareAdapter()
        {
        }
    }

    public class IBMRecordsUnit : DBRecordsUnit
    {
        private DB2Connection cn;
        private DB2DataAdapter adapter;
        private DB2CommandBuilder CmdBuilder;
        private DB2Command cmd;

        private void initObject()
        {
            cn = new DB2Connection(strConn);
            //if (!cn.IsOpen)
            //    cn.Open();
            adapter = new DB2DataAdapter(strCmdText, cn);
            CmdBuilder = new DB2CommandBuilder(adapter);
            cmd = new DB2Command(strCmdText, cn);
        }

        public IBMRecordsUnit()
        {
        }

        public IBMRecordsUnit(string conn)
        {
            strConn = conn;
            cn = new DB2Connection(strConn);
            adapter = new DB2DataAdapter();
        }

        public IBMRecordsUnit(string conn, string cmdtxt)
        {
            strConn = conn;
            cn = new DB2Connection(strConn);
            strCmdText = cmdtxt;
            adapter = new DB2DataAdapter(strCmdText, cn);
            CmdBuilder = new DB2CommandBuilder(adapter);
        }

        public override void FillDTRecords()
        {
            try
            {
                dtRecords.Clear();
                adapter.Fill(dtRecords);
            }
            catch (DB2Exception db2Exp)
            {
                throw db2Exp;
            }
        }

        public override void SaveChanges()
        {
            try
            {
                adapter.Update(dtRecords);
            }
            catch (DB2Exception db2Exp)
            {
                throw db2Exp;
            }
        }

        public override void PrepareAdapter()
        {
            if (cn == null)
                initObject();
            cmd.CommandText = strCmdText;
            adapter.SelectCommand = new DB2Command(strCmdText, cn);
            CmdBuilder = new DB2CommandBuilder(adapter);
        }
    }
}
