using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;

namespace UACSControls
{
    public partial class FrmSaddleShow : Form
    {
        public FrmSaddleShow()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.Load += FrmSaddleShow_Load;
        }

        private AreaBase areaBase = new AreaBase();
        public AreaBase AreaBase
        {
            get { return areaBase; }
            set { areaBase = value; }
        }
        conStockSaddleModel stockSaddleModel = null;



        void FrmSaddleShow_Load(object sender, EventArgs e)
        {
            //窗体固定大小
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;

            lblArea.Text = areaBase.AreaNo + "库位详细信息";

            stockSaddleModel = new conStockSaddleModel();

            stockSaddleModel.conInit(panel2, areaBase, constData.tagServiceName, panel2.Width, panel2.Height, constData.xAxisRight, constData.yAxisDown,constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY);

        }
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdata_Click(object sender, EventArgs e)
        {
            stockSaddleModel.conInit(panel2, areaBase, constData.tagServiceName, panel2.Width, panel2.Height, constData.xAxisRight, constData.yAxisDown,constData.Z2250BaySpaceX,
                constData.Z2250BaySpaceY);
        }

    }
}
