using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baosight.iSuperframe.Forms;
using System.Reflection;
using UACSDAL;
using UACSControls;
using Baosight.iSuperframe.Authorization.Interface;
using Baosight.iSuperframe.Common;
using UACSDAL.Common;

namespace UACSView.VIEW_UnitSaddle
{
    public partial class VIEW_H145ExitLineSaddle : FormBase
    {
        public VIEW_H145ExitLineSaddle()
        {
            InitializeComponent();
            //反射获取双缓存
            Type dgvType = this.dgvExitSaddleInfo.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dgvExitSaddleInfo, true, null);
            this.Load += VIEW_H145ExitLineSaddle_Load;

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED 
                return cp;
            }
        }

        private Baosight.iSuperframe.Authorization.Interface.IAuthorization auth;
        private UnitSaddleTagRead lineSaddleTag = new UnitSaddleTagRead();
        private UnitSaddleMethod saddleMethod = null;
        private UnitExitSaddleInfo exitSaddleInfo = new UnitExitSaddleInfo();

        private Dictionary<string, CoilUnitSaddle> dicSaddleControls = new Dictionary<string, CoilUnitSaddle>();
        private bool tabActived = true;

        private const string H145Unit = "H145"; 

        void VIEW_H145ExitLineSaddle_Load(object sender, EventArgs e)
        {
            auth = FrameContext.Instance.GetPlugin<IAuthorization>() as IAuthorization;
            //绑定鞍座控件
            dicSaddleControls["QWE12"] = coilUnitSaddle_QWE12;
            dicSaddleControls["QWE15"] = coilUnitSaddle_QWE15;
            dicSaddleControls["QWE16"] = coilUnitSaddle_QWE16;
            dicSaddleControls["QWE17"] = coilUnitSaddle_QWE17;
            dicSaddleControls["QWE22"] = coilUnitSaddle_QWE22;
            dicSaddleControls["QWE23"] = coilUnitSaddle_QWE23;
            dicSaddleControls["QWE24"] = coilUnitSaddle_QWE24;

            //coilUnitSaddleButton_QWE12.MySaddleNo = "QWE12";
            coilUnitSaddleButton_QWE15.MySaddleNo = "QWE15";
            //coilUnitSaddleButton_QWE16.MySaddleNo = "QWE16";
            //coilUnitSaddleButton_QWE17.MySaddleNo = "QWE17";
            //coilUnitSaddleButton_QWE22.MySaddleNo = "QWE22";
            //coilUnitSaddleButton_QWE23.MySaddleNo = "QWE23";
            coilUnitSaddleButton_QWE24.MySaddleNo = "QWE24";


            //实例化机组鞍座处理类
            saddleMethod = new UnitSaddleMethod(H145Unit, constData.ExitSaddleDefine, constData.tagServiceName);
            saddleMethod.ReadDefintion();

            lineSaddleTag.InitTagDataProvider(constData.tagServiceName);
            
            //把表中的tag名称赋值到控件中
            foreach (Control control in groupBox2.Controls)
            {
                //添加解锁鞍座控件
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    if (saddleMethod.DicSaddles.ContainsKey(t.MySaddleNo))
                    {
                        UnitSaddleBase theSaddleInfo = saddleMethod.DicSaddles[t.MySaddleNo];
                        if (!string.IsNullOrEmpty(theSaddleInfo.TagAdd_LockRequest) && theSaddleInfo.TagAdd_LockRequest != "")
                        {
                            t.MySaddleTagName_Feedback = theSaddleInfo.TagAdd_LockRequest_FEEDBACK;
                            t.MySaddleTagName_Set = theSaddleInfo.TagAdd_LockRequest_SET;
                            lineSaddleTag.AddTagName(theSaddleInfo.TagAdd_LockRequest_SET);
                            lineSaddleTag.AddTagName(theSaddleInfo.TagAdd_LockRequest_FEEDBACK);
                        }
                    }
                }
                //添加机组状态控件
                //if (control is CoilUnitStatus)
                //{
                //    CoilUnitStatus t = (CoilUnitStatus)control;
                //    if (!string.IsNullOrEmpty(t.MyStatusTagName) && t.MyStatusTagName != "")
                //    {
                //        lineSaddleTag.AddTagName(t.MyStatusTagName);
                //    }
                //}
                
            }
            foreach (Control control in groupBox3.Controls)
            {
                //添加解锁鞍座控件
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    if (saddleMethod.DicSaddles.ContainsKey(t.MySaddleNo))
                    {
                        UnitSaddleBase theSaddleInfo = saddleMethod.DicSaddles[t.MySaddleNo];
                        if (!string.IsNullOrEmpty(theSaddleInfo.TagAdd_LockRequest) && theSaddleInfo.TagAdd_LockRequest != "")
                        {
                            t.MySaddleTagName_Feedback = theSaddleInfo.TagAdd_LockRequest_FEEDBACK;
                            t.MySaddleTagName_Set = theSaddleInfo.TagAdd_LockRequest_SET;
                            lineSaddleTag.AddTagName(theSaddleInfo.TagAdd_LockRequest_SET);
                            lineSaddleTag.AddTagName(theSaddleInfo.TagAdd_LockRequest_FEEDBACK);
                        }
                    }
                }
            }

            lineSaddleTag.SetReady();
            //把实例化后的机组tag处理类装备每个控件
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    t.InitUnitSaddle(lineSaddleTag);
                }
            }
            foreach (Control control in groupBox3.Controls)
            {
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    t.InitUnitSaddle(lineSaddleTag);
                }
            }

            exitSaddleInfo.getExitSaddleDt(dgvExitSaddleInfo, H145Unit);
            //是否开启定时器
            timer_LineSaddleControl.Enabled = true;
            //设定刷新时间
            timer_LineSaddleControl.Interval = 5000;
        }
        private void getSaddleMessage()
        {
            saddleMethod.ReadDefintion();
            saddleMethod.getTagNameList();
            saddleMethod.getTagValues();

            foreach (string theL2SaddleName in dicSaddleControls.Keys)
            {
                if (saddleMethod.DicSaddles.ContainsKey(theL2SaddleName))
                {
                    CoilUnitSaddle conSaddle = dicSaddleControls[theL2SaddleName];

                    UnitSaddleBase theSaddleInfo = saddleMethod.DicSaddles[theL2SaddleName];

                    conSaddle.PosName = theSaddleInfo.SaddleNo;

                    //鞍座反馈
                    if (theSaddleInfo.TagVal_IsLocked == 1)
                        conSaddle.UpVisiable = true;
                    else
                        conSaddle.UpVisiable = false;

                    //鞍座占位
                    if (theSaddleInfo.TagVal_IsOccupied == 1)
                        conSaddle.CoilBackColor = Color.Green;
                    else
                        conSaddle.CoilBackColor = Color.LightGray;

                    //钢卷号
                    if (theSaddleInfo.CoilNO != string.Empty)
                    {
                        conSaddle.CoilId = theSaddleInfo.CoilNO;
                        conSaddle.CoilStatus = 2;
                    }
                    else
                    {
                        conSaddle.CoilId = "";
                        conSaddle.CoilStatus = -10;
                    }
                }

            }
        }

        private void timer_LineSaddleControl_Tick(object sender, EventArgs e)
        {
            //不在当前页面停止刷新
            if (tabActived == false)
            {
                return;
            }

            lineSaddleTag.readTags();

            foreach (Control control in groupBox3.Controls)
            {
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    if (!string.IsNullOrEmpty(t.MySaddleTagName_Feedback) && t.MySaddleTagName_Feedback != "")
                    {
                        CoilUnitSaddleButton.delRefresh_Button_Light del = t.refresh_Button_Light;
                        del(lineSaddleTag.getTagValue(t.MySaddleTagName_Feedback));
                    }
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    if (!string.IsNullOrEmpty(t.MySaddleTagName_Feedback) && t.MySaddleTagName_Feedback != "")
                    {
                        CoilUnitSaddleButton.delRefresh_Button_Light del = t.refresh_Button_Light;
                        del(lineSaddleTag.getTagValue(t.MySaddleTagName_Feedback));
                    }
                }
            }

            exitSaddleInfo.getExitSaddleDt(dgvExitSaddleInfo, H145Unit);

            getSaddleMessage();
        }


        //需要引用formbase
        void MyTabActivated(object sender, EventArgs e)
        {
            tabActived = true;
        }
        void MyTabDeactivated(object sender, EventArgs e)
        {
            tabActived = false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要返回2250热轧切边机组主画面吗？", "操作提示", btn);
            if (dr == DialogResult.OK)
            {
                auth.OpenForm("2250主画面");
            }
        }

        private void VIEW_H145ExitLineSaddle_Load_1(object sender, EventArgs e)
        {

        }
    }
}
