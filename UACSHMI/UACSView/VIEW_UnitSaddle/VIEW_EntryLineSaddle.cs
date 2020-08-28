using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace UACSView
{
    public partial class VIEW_EntryLineSaddle : Form
    {
        public VIEW_EntryLineSaddle()
        {
            InitializeComponent();


            Type dgvEntrySaddleType = this.dgvEntrySaddleInfo.GetType();
            PropertyInfo pi = dgvEntrySaddleType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dgvEntrySaddleInfo, true, null);

            Type dgvL2PlanType = this.dgvL2Plan.GetType();
            PropertyInfo pi1 = dgvL2PlanType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi1.SetValue(this.dgvL2Plan, true, null);
        }
 

    }
}
