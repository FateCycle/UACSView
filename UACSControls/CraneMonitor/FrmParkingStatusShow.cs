using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;
using System.Reflection;
using UACSControls;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;

namespace UACSControls
{
    public partial class FrmParkingStatusShow : Form
    {
        public FrmParkingStatusShow()
        {
            InitializeComponent();
        }
        private CraneStatusBase craneStatusBase = new CraneStatusBase();
        public delegate void RefreshControlInvoke(CraneStatusBase theCraneStatusBase);
        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDataProvider = null;
        private void FrmParkingStatusShow_Load(object sender, EventArgs e)
        {

        }

        string PackingArea = "CC1TV01";
        //车到
        private void btn_CarneArrive_Click(object sender, EventArgs e)
        {
            SendShortCmd(PackingArea, CraneStatusBase.btn_CarneArrive);
        }
        //车离
        private void btn_craneleave_Click(object sender, EventArgs e)
        {

        }
        //激光扫描
        private void btn_TREATMENT_Click(object sender, EventArgs e)
        {

        }

        private void SendShortCmd(string theNO, string  cmdFlag)
        {
            try
            {
                string messageBuffer = string.Empty;
                messageBuffer = theNO + "," + cmdFlag.ToString();
                Baosight.iSuperframe.TagService.DataCollection<object> wirteDatas = new Baosight.iSuperframe.TagService.DataCollection<object>();
                wirteDatas[theNO + "EV_PARKING_CARLEAVE"] = messageBuffer;
                tagDataProvider.SetData(theNO + "EV_PARKING_CARLEAVE", messageBuffer);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
