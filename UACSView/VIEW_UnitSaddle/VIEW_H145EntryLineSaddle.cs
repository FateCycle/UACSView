using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Baosight.iSuperframe.Forms;
using UACSDAL;
using UACSControls;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using UACSDAL.Common;

namespace UACSView.VIEW_UnitSaddle
{
    public partial class VIEW_H145EntryLineSaddle : FormBase
    {
        public VIEW_H145EntryLineSaddle()
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
            this.Load += VIEW_H145EntryLineSaddle_Load;
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
        private UnitEntrySaddleInfo entrySaddleInfo = new UnitEntrySaddleInfo();

        private Dictionary<string, CoilUnitSaddle> dicSaddleControls = new Dictionary<string, CoilUnitSaddle>();
        private bool tabActived = true;

        private const string H145Unit = "H145"; 
        void VIEW_H145EntryLineSaddle_Load(object sender, EventArgs e)
        {
            auth = FrameContext.Instance.GetPlugin<IAuthorization>() as IAuthorization;
            //绑定鞍座控件
            dicSaddleControls["CSD02"] = coilUnitSaddle_CSD02;
            dicSaddleControls["CSD01"] = coilUnitSaddle_CSD01;
            dicSaddleControls["QWD03"] = coilUnitSaddle_QWD03;
            dicSaddleControls["QWD02"] = coilUnitSaddle_QWD02;
            dicSaddleControls["QWD01"] = coilUnitSaddle_QWD01;

            coilUnitSaddleButton_CSD02.MySaddleNo = "CSD02";
            coilUnitSaddleButton_CSD01.MySaddleNo = "CSD01";
            //coilUnitSaddleButton_QWD03.MySaddleNo = "QWD03";
            //coilUnitSaddleButton_QWD02.MySaddleNo = "QWD02";
            coilUnitSaddleButton_QWD01.MySaddleNo = "QWD01";


            //实例化机组鞍座处理类
            saddleMethod = new UnitSaddleMethod(H145Unit, constData.EntrySaddleDefine, constData.tagServiceName);
            saddleMethod.ReadDefintion();

            lineSaddleTag.InitTagDataProvider(constData.tagServiceName);

            foreach (Control control in panelAutoScroll.Controls)
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
            //把表中的tag名称赋值到控件中
            foreach (Control control in groupBox4.Controls)
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

            lineSaddleTag.SetReady();
            //把实例化后的机组tag处理类装备每个控件
            foreach (Control control in panelAutoScroll.Controls)
            {
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    t.InitUnitSaddle(lineSaddleTag);
                }
            }
            foreach (Control control in groupBox4.Controls)
            {
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    t.InitUnitSaddle(lineSaddleTag);
                }
            }

            entrySaddleInfo.getEntrySaddleDt(dgvEntrySaddleInfo, H145Unit);
            entrySaddleInfo.getL2PlanByUnitNo(dgvL2Plan, H145Unit);
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

            foreach (Control control in panelAutoScroll.Controls)
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

                if (control is CoilUnitStatus)
                {
                    CoilUnitStatus t = (CoilUnitStatus)control;
                    if (!string.IsNullOrEmpty(t.MyStatusTagName) && t.MyStatusTagName != "")
                    {
                        CoilUnitStatus.delSetColor del = t.SetColor;
                        del(lineSaddleTag.getTagValue(t.MyStatusTagName));
                    }
                }
            }
            foreach (Control control in groupBox4.Controls)
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

            entrySaddleInfo.getEntrySaddleDt(dgvEntrySaddleInfo, H145Unit);
            entrySaddleInfo.getL2PlanByUnitNo(dgvL2Plan, H145Unit);

            lbl_NextCoil.Text = entrySaddleInfo.getCoilByUnitNo(H145Unit);

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

        private void VIEW_H145EntryLineSaddle_Load_1(object sender, EventArgs e)
        {

        }

        private void panelAutoScroll_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
