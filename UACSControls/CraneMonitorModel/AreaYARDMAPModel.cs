using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;

namespace UACSControls
{
  public class AreaYARDMAPModel
    {

        private delegate void AddAreaDelegate(conArea area);        // 创建委托和委托对象

        private AddAreaDelegate addAreaDelegate;

        private string bayNO = string.Empty;
        public string BayNO
        {
            get { return bayNO; }
            set { bayNO = value; }
        }
        private Panel bayPanel = new Panel();
        private long baySpaceX = 0;
        private long baySpaceY = 0;
        private int panelWidth = 0;
        private int panelHeight = 0;
        private bool xAxisRight = false;
        private bool yAxisDown = false;
       private AreaInfo theAreaInfoInBay = new AreaInfo();
        private AreaInfo theAreaInfoInBay1 = new AreaInfo();

        private string tagServiceName = string.Empty;

        private Dictionary<string, conArea> dicAreaVisual = new Dictionary<string, conArea>();
     
       
        public void refreshControl()
        {
            theAreaInfoInBay1.getPortionAreaData1();
         
        }



        }
}
