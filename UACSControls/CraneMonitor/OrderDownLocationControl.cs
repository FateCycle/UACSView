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
    public partial class OrderDownLocationControl : UserControl
    {
        public OrderDownLocationControl()
        {
            InitializeComponent();
        }
        public int POINT_WIDTH
        {
            get { return lblPoint.Width; }
        }
        public int POINT_HEIGHT
        {
            get { return lblPoint.Height; }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.DarkSeaGreen, lblPoint.Location.X + lblPoint.Width, lblPoint.Location.Y, richTLocation.Location.X, richTLocation.Location.Y + richTLocation.Height);
        }
    }
}
