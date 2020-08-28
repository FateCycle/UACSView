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
    public partial class Form_CareMessage : Form
    {

        public string bb;
        public Form_CareMessage(string mm)
        {
            InitializeComponent();
             bb= mm;
        }
        private void Form_CareMessage_Load(object sender, EventArgs e)
        {
            label2.Text = bb;
        }
    }
}
