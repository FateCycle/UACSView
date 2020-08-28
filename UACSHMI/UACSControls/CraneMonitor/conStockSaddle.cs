using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;
using UACSPopupForm;

namespace UACSControls
{
    public partial class conStockSaddle : UserControl
    {
        public conStockSaddle()
        {
            InitializeComponent();
            this.SetStyle(
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw |
               ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }  
        private SaddleBase mySaddleInfo = new SaddleBase();
        private Label lblRowNo = new Label();
        private Label lblColNo = new Label();

        private int Location_X;
        private int Location_Y;

        private int width;
        private int height;

        private Graphics gr;
        public delegate void EventHandler_Saddle_Selected(SaddleBase theSaddleInfo);
        public event EventHandler_Saddle_Selected Saddle_Selected;
        public void conInit()
        {
            try
            {
                this.panel1.MouseDown += new MouseEventHandler(conSaddle_visual_MouseUp);

            }
            catch (Exception ex)
            {
            }
        }

        void conSaddle_visual_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (Saddle_Selected != null)
                    {
                        Saddle_Selected(mySaddleInfo.Clone());
                    }
                }
                else
                {
                    FrmSaddleMetail FrmSaddleDetail = new FrmSaddleMetail();
                    FrmSaddleDetail.SaddleInfo = this.mySaddleInfo;
                    FrmSaddleDetail.Show();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public delegate void saddlesRefreshInvoke(SaddleBase theSaddle, double X_Width, double Y_Height, AreaBase theArea, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, Panel panel, long baySpaceX, long baySpaceY);

        public void refreshControl(SaddleBase theSaddle, double X_Width, double Y_Height, AreaBase theArea, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown, Panel panel, long baySpaceX, long baySpaceY)
         {
             try
             {
                 //附对象
                 mySaddleInfo = theSaddle;
                 width = panelWidth;
                 height = panelHeight;
                 
                 //计算X方向上的比例关系
                 double xScale;
                 if (theArea.AreaNo == "EY1" || theArea.AreaNo == "EY2" || theArea.AreaNo == "EY3")
                 {
                     xScale = Convert.ToDouble(panelWidth - 150) / Convert.ToDouble(X_Width);
                 }
                 else
                 {
                     xScale = Convert.ToDouble(panelWidth - 10) / Convert.ToDouble(X_Width);
                 }
                
                 double location_X = 0;
                 if (xAxisRight == true)
                 {
                     location_X = Convert.ToDouble((theSaddle.X_Center - theSaddle.SaddleLength / 2) - theArea.X_Start) * xScale;
                 }  
                 else
                 {
                     location_X = Convert.ToDouble(Math.Abs((theArea.X_End - (theSaddle.X_Center - theSaddle.SaddleLength / 2)))) * xScale;
                 }

                 //计算Y方向的比例关系
                 double yScale;
                 if (theArea.AreaNo == "EY1" || theArea.AreaNo == "EY2" || theArea.AreaNo == "EY3")
                 {
                     yScale = Convert.ToDouble(panelHeight - 90) / Convert.ToDouble(Y_Height);
                 }
                 else
                 {
                     yScale = Convert.ToDouble(panelHeight) / Convert.ToDouble(Y_Height);
                 }
                 
                 double location_Y = 0;
                 if (yAxisDown == true)
                 {
                     location_Y = ((theSaddle.Y_Center - theSaddle.SaddleWidth / 2) - theArea.Y_Start) * yScale;
                 }
                 else
                 {
                     location_Y = Convert.ToDouble(theArea.Y_End - (theSaddle.Y_Center - theSaddle.SaddleWidth / 2)) * yScale;
                 }

                 
                 Location_X = (int)location_X;
                 Location_Y = (int)location_Y;

                 if (theSaddle.Stock_Status == 0 && theSaddle.Lock_Flag == 0) //无卷可用
                     this.BackColor = Color.White;
                 else if (theSaddle.Stock_Status == 2 && theSaddle.Lock_Flag == 0) //有卷可用
                 {
                     //区分机组
                    if (theSaddle.Next_Unit_No == "D118" || theSaddle.Next_Unit_No == "D218")
                        this.BackColor = Color.Yellow;
                    else if (theSaddle.Next_Unit_No == "D308" || theSaddle.Next_Unit_No == "D212")
                        this.BackColor = Color.Green;   
                    else
                        this.BackColor = Color.Black;
                 }
                 else
                     this.BackColor = Color.Red;

                 //修改鞍座控件的宽度和高度
                 this.Width = Convert.ToInt32(theSaddle.SaddleWidth * xScale);
                 this.Height = Convert.ToInt32(theSaddle.SaddleLength * yScale);
                
                 //定位库位鞍座的坐标
                 if (theSaddle.Layer_Num == 2)
                 {
                     this.Location = new Point(Convert.ToInt32(location_X), Convert.ToInt32(location_Y ) - 20);
                 }
                 else
                 {
                     this.Location = new Point(Convert.ToInt32(location_X), Convert.ToInt32(location_Y));
                 }
                 

                 this.BringToFront();

                 //if (theSaddle.SaddleNo.Substring( Convert.ToInt32( theSaddle.SaddleNo.Length.ToString()) - 1,1) == "2")
                 //    this.BorderStyle = BorderStyle.Fixed3D;
                 //else
                     this.BorderStyle = BorderStyle.None;

                 gr = panel.CreateGraphics();
                 panel.Paint += panel_Paint;

                 this.panel1.Paint += conStockSaddle_Paint;
                
                 toolTip1.IsBalloon = true;
                 toolTip1.ReshowDelay = 0;
                 toolTip1.SetToolTip(this.panel1, "材料号：" + theSaddle.Mat_No + "\r"
                                     + "库位：    " + theSaddle.SaddleNo.ToString()
                                     + "\r" + theSaddle.Row_No.ToString() + "行" + "-" + theSaddle.Col_No.ToString() + "列，" + "\r"
                                     + "坐标：" + "\r"
                                     + "X = " + theSaddle.X_Center + "\r"
                                     + "Y = " + theSaddle.Y_Center + "\r"
                                     + "Z = " + theSaddle.Z_Center + "\r"
                                     + "下道机组： " + theSaddle.Next_Unit_No + "\r"
                                    );
             }
             catch (Exception er)
             {            
                 throw;
             }
         }

        void panel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (mySaddleInfo != null)
                {
                    Pen p1 = new Pen(Color.Blue, 1);
                    if (mySaddleInfo.Row_No == 1 && mySaddleInfo.Layer_Num != 2)
                    {
                        string row = mySaddleInfo.SaddleNo.Substring(7, 1);
                        gr.DrawString(row, new Font("微软雅黑", 10, FontStyle.Bold), Brushes.Red,
                            new Point(Convert.ToInt32(Location_X  - 30), Convert.ToInt32(Location_Y)));

                        gr.DrawLine(p1, 0, Convert.ToInt32(Location_Y ) + 30, width, Convert.ToInt32(Location_Y) + 30);
                    }
                }
            }
            catch (Exception er)
            {

                LogManager.WriteProgramLog(er.Message,er.StackTrace);
            }
           
           
        }

        private void conStockSaddle_Paint(object sender, PaintEventArgs e)
        {
            string col = mySaddleInfo.SaddleNo.Substring(4, 2);
            Graphics gr = this.CreateGraphics();
            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Center; //居中
            Rectangle 矩形 = new Rectangle(0, 0, this.panel1.Width, this.panel1.Height);
            Font size = new Font("微软雅黑", 10F,FontStyle.Bold);
            Brush br = Brushes.Red; ;
            gr.DrawString(col, size, br, 矩形, str);
        }
    }
}
