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
    public partial class conUnitSaddle : UserControl
    {
        public conUnitSaddle()
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

                double location_X = 0;
                if (xAxisRight == true)
                    location_X = Convert.ToDouble(theSaddle.XCENTER - theSaddle.STOCK_LENGTH / 2) * xScale;
                else
                    location_X = Convert.ToDouble(baySpaceX - (theSaddle.XCENTER+ theSaddle.STOCK_LENGTH / 2)) * xScale;


                //计算Y方向的比例关系
                double yScale = Convert.ToDouble(panelHeight) / Convert.ToDouble(baySpaceY);

                double location_Y = 0;
                if (yAxisDown == true)
                    location_Y = (theSaddle.YCENTER - theSaddle.SaddleWidth) * yScale;
                else
                    location_Y = (baySpaceY - (theSaddle.YCENTER + theSaddle.SaddleWidth)) * yScale;

                //修改鞍座控件的宽度和高度
                this.Width = Convert.ToInt32(theSaddle.STOCK_LENGTH * xScale);
                this.Height = Convert.ToInt32(800 * yScale);

                //定位库位鞍座的坐标
                this.Location = new Point(Convert.ToInt32(location_X), Convert.ToInt32(location_Y));

                if (theSaddle.CoilNO=="" && theSaddle.CoilNO1=="")
                {
                  
                    lblMatNo2.Visible = false;
                    lblMatNo1.Visible = false;

                }
                else if (theSaddle.CoilNO == "" || theSaddle.CoilNO1 == "")
                {

                    lblMatNo2.Visible = false;
                    toolTip1.IsBalloon = true;
                    toolTip1.ReshowDelay = 0;
                    toolTip1.AutoPopDelay = 5000;
                    toolTip1.InitialDelay = 0;
                    toolTip1.ShowAlways = true;
                    toolTip1.SetToolTip(lblMatNo1, "鞍座号：" + theSaddle.STOCK_NO.ToString() + "\r"
                                        + "方坯号1：" + theSaddle.CoilNO + "\r"
                                        + "方坯号2：" + theSaddle.CoilNO1 + "\r"
                                        //+ "占位值：" + theSaddle.TagVal_IsOccupied + "\r"
                                        //+ "锁定请求：" + theSaddle.Tag_Lock_Request_Value + "\r"
                                        + "坐标：" + "\r"
                                        + "X = " + theSaddle.XCENTER + "\r"
                                        + "Y = " + theSaddle.YCENTER + "\r"
                                       //+ "------------------------" + "\r"
                                       //+ "出口占位为1,入口占位为0" + "\r"
                                       //+ "黑色代表有占位有卷号" + "\r"
                                       //+ "橙色代表占位、卷号只有其中一个" + "\r"
                                       //+ "红色代表机组鞍座已锁定" + "\r"
                                       );
                }
                else
                {



                    toolTip1.IsBalloon = true;
                    toolTip1.ReshowDelay = 0;
                    toolTip1.AutoPopDelay = 5000;
                    toolTip1.InitialDelay = 0;
                    toolTip1.ShowAlways = true;
                    toolTip1.SetToolTip(lblMatNo1, "鞍座号：" + theSaddle.STOCK_NO.ToString() + "\r"
                                        + "方坯号1：" + theSaddle.CoilNO + "\r"
                                        + "方坯号2：" + theSaddle.CoilNO1 + "\r"
                                        //+ "占位值：" + theSaddle.TagVal_IsOccupied + "\r"
                                        //+ "锁定请求：" + theSaddle.Tag_Lock_Request_Value + "\r"
                                        + "坐标：" + "\r"
                                        + "X = " + theSaddle.XCENTER + "\r"
                                        + "Y = " + theSaddle.YCENTER + "\r"
                                       //+ "------------------------" + "\r"
                                       //+ "出口占位为1,入口占位为0" + "\r"
                                       //+ "黑色代表有占位有卷号" + "\r"
                                       //+ "橙色代表占位、卷号只有其中一个" + "\r"
                                       //+ "红色代表机组鞍座已锁定" + "\r"
                                       );
                    toolTip1.SetToolTip(lblMatNo2, "鞍座号：" + theSaddle.STOCK_NO.ToString() + "\r"
                                        + "方坯号1：" + theSaddle.CoilNO + "\r"
                                        + "方坯号2：" + theSaddle.CoilNO1 + "\r"
                                        //+ "占位值：" + theSaddle.TagVal_IsOccupied + "\r"
                                        //+ "锁定请求：" + theSaddle.Tag_Lock_Request_Value + "\r"
                                        + "坐标：" + "\r"
                                        + "X = " + theSaddle.XCENTER + "\r"
                                        + "Y = " + theSaddle.YCENTER + "\r"
                                       //+ "------------------------" + "\r"
                                       //+ "出口占位为1,入口占位为0" + "\r"
                                       //+ "黑色代表有占位有卷号" + "\r"
                                       //+ "橙色代表占位、卷号只有其中一个" + "\r"
                                       //+ "红色代表机组鞍座已锁定" + "\r"
                                       );
                };
                ////出口机组占位值
                //if (theSaddle.SaddleNo.IndexOf("C") > -1)
                //{
                //    if (!string.IsNullOrEmpty(theSaddle.CoilNO.Trim()))
                //    {
                //        if (theSaddle.TagVal_IsOccupied == 1)
                //        {
                //            this.BackColor = Color.Black;
                //        }
                //        else
                //        {
                //            this.BackColor = Color.LightSalmon;
                //        }
                //    }
                //    else
                //    {
                //        if (theSaddle.TagVal_IsOccupied == 1)
                //        {
                //            this.BackColor = Color.LightSalmon;
                //        }
                //        else
                //        {
                //            this.BackColor = Color.White;
                //        }
                //    }
                //}
                //else if (theSaddle.SaddleNo.IndexOf("R") > -1)  //入口机组占位值
                //{
                //    //钢卷不为空
                //    if (!string.IsNullOrEmpty(theSaddle.CoilNO.Trim()))
                //    {
                //        //特殊情况(鞍座没有占位)
                //        if (theSaddle.SaddleNo.Trim() == "D413SR1A00" || theSaddle.SaddleNo.Trim() == "D413SR1A01" || theSaddle.SaddleNo.Trim() == "D413SR1A02" || theSaddle.SaddleNo.Trim() == "D413SR1A03" ||
                //            theSaddle.SaddleNo.Trim() == "D413SR1A04" || theSaddle.SaddleNo.Trim() == "D413SR1A06" || theSaddle.SaddleNo.Trim() == "D413SR1A07" || theSaddle.SaddleNo.Trim() == "D413SR1A08" ||
                //            theSaddle.SaddleNo.Trim() == "D413SR1A09")
                //        {
                //            this.BackColor = Color.Black;
                //        }
                //        else
                //        {
                //            // 鞍座有占位
                //            if (theSaddle.TagVal_IsOccupied == 0)
                //            {
                //                this.BackColor = Color.Black;
                //            }
                //            else
                //            {
                //                this.BackColor = Color.LightSalmon;
                //            }
                //        }

                //    }
                //    else
                //    {
                //        if (theSaddle.TagVal_IsOccupied == 0)
                //        {
                //            ////特殊情况(鞍座没有占位)
                //            if (theSaddle.SaddleNo.Trim() == "D308WR1A05" || theSaddle.SaddleNo.Trim() == "D413SR1A00" || theSaddle.SaddleNo.Trim() == "D413SR1A01" || theSaddle.SaddleNo.Trim() == "D413SR1A02" || theSaddle.SaddleNo.Trim() == "D413SR1A03" ||
                //            theSaddle.SaddleNo.Trim() == "D413SR1A04" || theSaddle.SaddleNo.Trim() == "D413SR1A06" || theSaddle.SaddleNo.Trim() == "D413SR1A07" || theSaddle.SaddleNo.Trim() == "D413SR1A08" ||
                //            theSaddle.SaddleNo.Trim() == "D413SR1A09")  //特殊情况
                //                this.BackColor = Color.White;
                //            else
                //                this.BackColor = Color.LightSalmon;
                //        }
                //        else
                //        {
                //            this.BackColor = Color.White;
                //        }         
                //    }
                //}

                ////已锁定机组鞍座
                //if (theSaddle.Tag_IsLocked_Value == 1)
                //{
                //    this.BackColor = Color.Red;
                //}

                //X或Y等于小于 0时，不显示
               // || theSaddle.XCENTER == 999999 || theSaddle.YCENTER == 999999
                if (theSaddle.XCENTER == 0 || theSaddle.YCENTER ==0)
                {
                  this.Visible = false;
             }
            }
            catch (Exception ex)
            {
                LogManager.WriteProgramLog(ex.Message);
                LogManager.WriteProgramLog(ex.StackTrace);
            }
        }


        public delegate void EventHandler_Saddle_Selected(SaddleBase theSaddleInfo);
        public event EventHandler_Saddle_Selected Saddle_Selected;

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
