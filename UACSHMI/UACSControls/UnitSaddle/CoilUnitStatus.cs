using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UACSControls
{
    public partial class CoilUnitStatus : UserControl
    {

        public CoilUnitStatus()
        {
            InitializeComponent();
        }

        private string myStatusTagName = "";
        [Description("对应状态的tag名")]
        public string MyStatusTagName
        {
            get { return myStatusTagName; }
            set { myStatusTagName = value; }
        }

        public delegate void delSetColor(long theValue);

        public void SetColor(long theValue)
        {
            if (theValue == 1)
            {
                plColor.BackColor = Color.LightGreen;
            }
            else
            {
                plColor.BackColor = Color.Red;
            }
        }
    }
}
