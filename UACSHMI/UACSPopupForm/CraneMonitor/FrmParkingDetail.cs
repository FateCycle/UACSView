using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;

namespace UACSPopupForm
{
    public partial class FrmParkingDetail : Form
    {
        public FrmParkingDetail()
        {
            InitializeComponent();
        }

        private ParkingBase packingInfo;
        public ParkingBase PackingInfo
        {
            get { return packingInfo; }
            set { packingInfo = value; }
        }

        private void FrmParkingDetail_Load(object sender, EventArgs e)
        {
            lblCarNo.Text = packingInfo.Car_No;
            lblCarStatus.Text = packingInfo.PackingStatusDesc();
            lblPacking.Text = packingInfo.ParkingName;
            lblCarType.Text = ParkingInfo.getStowageCarType(packingInfo.STOWAGE_ID);
            ParkingInfo.dgvStowageMessage(packingInfo.STOWAGE_ID, dgvStowageMessage);
            ParkingInfo.dgvStowageOrder(packingInfo.ParkingName, dgvCraneOder);
            ShiftStowageMessage();
            this.Deactivate += new EventHandler(frmSaddleDetail_Deactivate);
        }
        void frmSaddleDetail_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void ShiftStowageMessage()
        {
            for (int i = 0; i < dgvStowageMessage.Rows.Count; i++)
            {
                dgvStowageMessage.Rows[i].DefaultCellStyle.BackColor = Color.White;
                if (dgvStowageMessage.Rows[i].Cells["STATUS"].Value != DBNull.Value)
                {
                    if (dgvStowageMessage.Rows[i].Cells["STATUS"].Value.ToString() == "执行完")
                    {
                        dgvStowageMessage.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                    }
                }
            }
        }
        
    }
}
