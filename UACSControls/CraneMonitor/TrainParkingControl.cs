using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL.CraneMonitor;
namespace UACSControls.CraneMonitor
{
    public partial class TrainParkingControl : UserControl
    {
        public TrainParkingControl()
        {
            InitializeComponent();
        }
        private void InitDataInfo()
        {
            labFLAG01.Text = labFLAG02.Text = labFLAG03.Text =
            labSTATUS01.Text = labSTATUS02.Text = labSTATUS03.Text = string.Empty;
        }
        public void RefreshData(List<TLineSlabInfo> lst)
        {
            InitDataInfo();

            for (int i = 0; i < lst.Count; i++)
            {
                switch (lst[i].PARK_POS)
                {
                    case "1#":
                        string TextFlay = lst[i].LOAD_FLAG;
                        if (TextFlay == "1")
                        {
                            labFLAG01.Text = "装满";
                            labFLAG01.BackColor = Color.DarkOrange;
                        }
                        else
                        {
                            labFLAG01.Text = "未装满";
                            labFLAG01.BackColor = Color.IndianRed;

                        }
                        string TextStatus = lst[i].STOCK_STATUS;
                        if (TextStatus == "OCCUPY")
                        {
                            labSTATUS01.Text = "有盖";
                            labSTATUS01.BackColor = Color.Brown;
                        }
                        else
                        {
                            labSTATUS01.Text = "无盖";
                            labSTATUS01.BackColor = Color.LightBlue;
                        }
                        break;
                    case "2#":
                        string TextFlay2 = lst[i].LOAD_FLAG;
                        if (TextFlay2 == "1")
                        {
                            labFLAG02.Text = "装满";
                            labFLAG02.BackColor = Color.DarkOrange;
                        }
                        else
                        {
                            labFLAG02.Text = "未装满";
                            labFLAG02.BackColor = Color.IndianRed;

                        }
                        string TextStatus2 = lst[i].STOCK_STATUS;
                        if (TextStatus2 == "OCCUPY")
                        {
                            labSTATUS02.Text = "有盖";
                            labSTATUS02.BackColor = Color.Brown;
                        }
                        else
                        {
                            labSTATUS02.Text = "无盖";
                            labSTATUS02.BackColor = Color.LightBlue;
                        }
                        break;
                    case "3#":
                        string TextFlay3 = lst[i].LOAD_FLAG;
                        if (TextFlay3 == "1")
                        {
                            labFLAG03.Text = "装满";
                            labFLAG03.BackColor = Color.DarkOrange;
                        }
                        else
                        {
                            labFLAG03.Text = "未装满";
                            labFLAG03.BackColor = Color.IndianRed;

                        }
                        string TextStatus3 = lst[i].STOCK_STATUS;
                        if (TextStatus3 == "OCCUPY")
                        {
                            labSTATUS03.Text = "有盖";
                            labSTATUS03.BackColor = Color.Brown;
                        }
                        else
                        {
                            labSTATUS03.Text = "无盖";
                            labSTATUS03.BackColor = Color.LightBlue;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void labSTATUS03_Click(object sender, EventArgs e)
        {

        }
    }
}
