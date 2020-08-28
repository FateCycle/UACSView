using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UACSControls.CraneMonitor
{
    public partial class CustomGrpTitle : UserControl
    {

           [Description("标题文字"), Category("自定义")]
         public string TipsText
         {
             get
             {
                 return this.lblTitle.Text;
             }
             set
             {
                 this.lblTitle.Text = value;
             }
         }
public CustomGrpTitle()
        {
            InitializeComponent();
        }
    }
}
