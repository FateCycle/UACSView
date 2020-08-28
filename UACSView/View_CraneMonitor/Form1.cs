using Baosight.iSuperframe.Forms;
using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UACSDAL.Common;

namespace UACSView.View_CraneMonitor
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DB2DataAdapter _dataAdapter;
        DB2CommandBuilder cmdBuilder;
        private DataTable _dataTable = new DataTable();
        DB2Connection conn;
        BindingSource _dataBindSource = new BindingSource();
        string _selectNodeName = string.Empty;
        Dictionary<string, string> _tableNameDic = new Dictionary<string, string> { { "CraneAlarmInfo", "UACS_CRANE_ALARM_CODE_DEFINE" }, { "CraneWMSAlarmInfo", "UACS_CRANE_EVADE_REQUEST" } };
        private void treeRootView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (_tableNameDic.ContainsKey(treeRootView.SelectedNode.Name))
                {
                    _dataTable = new DataTable();
                    string strSql = string.Format("SELECT * FROM {0}", _tableNameDic[treeRootView.SelectedNode.Name]);
                    conn = new DB2Connection(GetConnString("localAPP"));
                    _dataAdapter = new DB2DataAdapter(strSql, conn);;
                    _dataAdapter.Fill(_dataTable);
                    cmdBuilder = new DB2CommandBuilder(_dataAdapter);
                    //_dataBindSource = new BindingSource();
                    _dataBindSource.DataSource = _dataTable;
                    dgv.DataSource = _dataTable;
                    _selectNodeName = treeRootView.SelectedNode.Name;
                    //_dataBindSource.DataSource = _dataTable;
                }
                else
                {
                    if (_dataAdapter!=null)
                    {
                        _dataAdapter.Dispose();
                    }
                    _dataTable = new DataTable();
                    dgv.DataSource = _dataTable;
                    _dataBindSource.DataSource = _dataTable;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_dataAdapter == null)
            {
                MessageBox.Show("无法更新数据库!");
                return;
            }
            if (dgv.Rows.Count < 1)
            {
                return;
            }
            //cmdBuilder = new DB2CommandBuilder(_dataAdapter);
            _dataAdapter.Update(_dataTable);
            SearchNodes(_selectNodeName, treeRootView.Nodes[0]);
        }
        public static string GetConnString(string strName)
        {
            string configFullName = Environment.GetEnvironmentVariable("IPLATURE") + @"SF_HOME\config\SuperFrame.config";
            string strconn = XmlHelper.Read(configFullName, string.Format("configuration/dbConfiguration/Dbs/add[@name='{0}']", strName), "connectionString");
            return strconn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_dataAdapter == null)
            {
                MessageBox.Show("无法更新数据库!");
                return;
            }
            if (dgv.Rows.Count < 1)
            {
                return;
            }
            dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
            //cmdBuilder = new DB2CommandBuilder(_dataAdapter);
            _dataAdapter.Update(_dataTable);
            SearchNodes(_selectNodeName, treeRootView.Nodes[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count < 1)
            {
                return;
            }
            dgv.DataSource = null;
            _dataTable.Rows.Add();
            dgv.DataSource = _dataTable;
            dgv.CurrentCell= dgv.Rows[dgv.Rows.Count-1].Cells[0];
            SearchNodes(_selectNodeName, treeRootView.Nodes[0]);

            //DB2CommandBuilder CmdBuilder = new DB2CommandBuilder(_adp);
            //_adp.Update(_dt);
        }
        private void InitDataGridView()
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToOrderColumns = false;
            //dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.EnableHeadersVisualStyles = false;
            //dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.BackgroundColor = SystemColors.Info;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dgv.RowHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;

            dgv.RowsDefaultCellStyle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgv, true, null);
        }
        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            while (StartNode != null)
            {
                if (StartNode.Name.ToLower().Contains(SearchText.ToLower()))
                {
                    //  CurrentNodeMatches.Add(StartNode);
                    //treeView_AfterSelect_bit = false;
                    treeRootView.SelectedNode = StartNode;
                    treeRootView.SelectedNode.Expand();
                    treeRootView.Select();
                    //treeView_AfterSelect_bit = true;
                }

                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//递归搜索
                }
                StartNode = StartNode.NextNode;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitDataGridView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
