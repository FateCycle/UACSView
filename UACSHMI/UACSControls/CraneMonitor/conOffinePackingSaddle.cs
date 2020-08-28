using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;

namespace UACSControls
{
    public partial class conOffinePackingSaddle : UserControl
    {
        public conOffinePackingSaddle()
        {
            InitializeComponent();
        }


        public delegate void saddlesRefreshInvoke(SaddleBase theSaddle, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown);

        public void refreshControl(SaddleBase theSaddle, long baySpaceX, long baySpaceY, int panelWidth, int panelHeight, bool xAxisRight, bool yAxisDown)
        {
            try
            {
                //计算X方向上的比例关系
                double xScale = Convert.ToDouble(panelWidth) / Convert.ToDouble(baySpaceX);

                //计算控件行车中心X，区分为X坐标轴向左或者向右
                double location_X = 0;
                if (xAxisRight == true)
                    location_X = Convert.ToDouble(theSaddle.X_Center - theSaddle.SaddleLength / 2) * xScale;
                else
                    location_X = Convert.ToDouble(baySpaceX - (theSaddle.X_Center + theSaddle.SaddleLength / 2)) * xScale;


                //计算Y方向的比例关系
                double yScale = Convert.ToDouble(panelHeight) / Convert.ToDouble(baySpaceY);

                //计算行车中心Y 区分Y坐标轴向上或者向下
                double location_Y = 0;
                if (yAxisDown == true)
                    location_Y = (theSaddle.Y_Center - theSaddle.SaddleWidth / 2) * yScale;
                else
                    location_Y = (baySpaceY - (theSaddle.Y_Center + theSaddle.SaddleWidth / 2)) * yScale;

                //修改鞍座控件的宽度和高度
                this.Width = Convert.ToInt32(theSaddle.SaddleWidth * xScale);
                this.Height = Convert.ToInt32(theSaddle.SaddleLength * yScale);

                if (theSaddle.Stock_Status == 0 && theSaddle.Lock_Flag == 0) //无卷可用
                    this.BackColor = Color.White;
                else if (theSaddle.Stock_Status == 2 && theSaddle.Lock_Flag == 0) //有卷可用                
                    this.BackColor = Color.Black;
                else
                    this.BackColor = Color.Red;


                //定位库位鞍座的坐标
                this.Location = new Point(Convert.ToInt32(location_X), Convert.ToInt32(location_Y));


                toolTip1.IsBalloon = true;
                toolTip1.ReshowDelay = 0;
                toolTip1.SetToolTip(this, "材料号：" + theSaddle.Mat_No + "\r"
                                    + "库位：    " + theSaddle.SaddleNo.ToString()
                                    + "\r" + theSaddle.Row_No.ToString() + "行" + "-" + theSaddle.Col_No.ToString() + "列，" + "\r"
                                    + "坐标：" + "\r"
                                    + "X = " + theSaddle.X_Center + "\r"
                                    + "Y = " + theSaddle.Y_Center + "\r"
                                    + "下道机组： " + theSaddle.Next_Unit_No + "\r");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
