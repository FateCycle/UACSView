using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;

namespace UACSControls.CraneMonitor
{
    public partial class ParkingStausControl : UserControl
    {
        public ParkingStausControl()
        {
            InitializeComponent();
        }
        private string _parkingNo;
        public string PARKING_NO
        {
            get { return _parkingNo; }
            set { _parkingNo = value;lblParkingNo.Text = _parkingNo; }
        }
        private void InitDataInfo()
        {
            lblCarNo.Text = lblTreatmentNo.Text = lblWorkType.Text = lblScanCount.Text = lblScanCount.Text = lblParkingStatus.Text;
        }
        public void RefreshData(ParkingBase parkingBase)
        {
            InitDataInfo();
            lblCarNo.Text = parkingBase.Car_No;
            lblTreatmentNo.Text = parkingBase.TREATMENT_NO;
            lblWorkType.Text = parkingBase.IsLoaded==0?"出库":parkingBase.IsLoaded==1?"入库":"未知";
            lblScanCount.Text = parkingBase.LASER_COUNT.ToString();
            lblParkingStatus.Text = parkingBase.PackingStatusDesc();
        }

        private void lblParkingStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
