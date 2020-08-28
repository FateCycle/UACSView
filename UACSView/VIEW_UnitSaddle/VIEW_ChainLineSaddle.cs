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
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using UACSDAL.Common;

namespace UACSView.VIEW_UnitSaddle
{
    public partial class VIEW_ChainLineSaddle : FormBase
    {
        public VIEW_ChainLineSaddle()
        {
            InitializeComponent();
            //反射获取双缓存
            Type dgvType = this.dgvExitSaddleInfo.GetType();
            Type dgvType2 = this.dgvExitSaddleInfo.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            PropertyInfo pi2 = dgvType2.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dgvExitSaddleInfo, true, null);
            pi2.SetValue(this.dgvEntrySaddleInfo, true, null);
            this.Load += VIEW_ChainLineSaddle_Load;

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
        private UnitSaddleMethod exitSaddleMethod = null;
        private UnitSaddleMethod entrySaddleMethod = null;
        private UnitExitSaddleInfo exitSaddleInfo = new UnitExitSaddleInfo();
        private UnitEntrySaddleInfo entrySaddleInfo = new UnitEntrySaddleInfo();

        private Dictionary<string, CoilUnitSaddle> dicSaddleControls = new Dictionary<string, CoilUnitSaddle>();
        private bool tabActived = true;

        private const string Chain = "CH01"; 

        void VIEW_ChainLineSaddle_Load(object sender, EventArgs e)
        {
            auth = FrameContext.Instance.GetPlugin<IAuthorization>() as IAuthorization;
            //绑定鞍座控件
            dicSaddleControls["PCQ17Z0"] = coilUnitSaddle_PCQ17Z0;
            dicSaddleControls["PCQ16Z0"] = coilUnitSaddle_PCQ16Z0;
            dicSaddleControls["PCQ15Z0"] = coilUnitSaddle_PCQ15Z0;
            dicSaddleControls["PCQ14Z0"] = coilUnitSaddle_PCQ14Z0;
            dicSaddleControls["PCQ13Z0"] = coilUnitSaddle_PCQ13Z0;
            dicSaddleControls["PCQ12Z0"] = coilUnitSaddle_PCQ12Z0;
            dicSaddleControls["PCQ10Z0"] = coilUnitSaddle_PCQ10Z0;
            dicSaddleControls["PCQ09Z0"] = coilUnitSaddle_PCQ09Z0;
            dicSaddleControls["PCQ08Z0"] = coilUnitSaddle_PCQ08Z0;
            dicSaddleControls["PCQ07Z0"] = coilUnitSaddle_PCQ07Z0;
            dicSaddleControls["PCQ06Z0"] = coilUnitSaddle_PCQ06Z0;
            dicSaddleControls["PCQ05Z0"] = coilUnitSaddle_PCQ05Z0;
            dicSaddleControls["PCQ04Z0"] = coilUnitSaddle_PCQ04Z0;
            dicSaddleControls["PCQ03Z0"] = coilUnitSaddle_PCQ03Z0;

            coilUnitSaddleButton_PCQ17Z0.MySaddleNo = "PCQ17Z0";
            coilUnitSaddleButton_PCQ16Z0.MySaddleNo = "PCQ16Z0";
            coilUnitSaddleButton_PCQ15Z0.MySaddleNo = "PCQ15Z0";
            coilUnitSaddleButton_PCQ14Z0.MySaddleNo = "PCQ14Z0";
            coilUnitSaddleButton_PCQ13Z0.MySaddleNo = "PCQ13Z0";
            coilUnitSaddleButton_PCQ12Z0.MySaddleNo = "PCQ12Z0";
            coilUnitSaddleButton_PCQ10Z0.MySaddleNo = "PCQ10Z0";
            coilUnitSaddleButton_PCQ09Z0.MySaddleNo = "PCQ09Z0";
            coilUnitSaddleButton_PCQ08Z0.MySaddleNo = "PCQ08Z0";
            coilUnitSaddleButton_PCQ07Z0.MySaddleNo = "PCQ07Z0";
            coilUnitSaddleButton_PCQ06Z0.MySaddleNo = "PCQ06Z0";
            coilUnitSaddleButton_PCQ05Z0.MySaddleNo = "PCQ05Z0";
            coilUnitSaddleButton_PCQ04Z0.MySaddleNo = "PCQ04Z0";
            coilUnitSaddleButton_PCQ03Z0.MySaddleNo = "PCQ03Z0";


            //实例化机组鞍座处理类
            exitSaddleMethod = new UnitSaddleMethod(Chain, constData.ExitSaddleDefine, constData.tagServiceName);
            exitSaddleMethod.ReadDefintion();
            entrySaddleMethod = new UnitSaddleMethod(Chain, constData.EntrySaddleDefine, constData.tagServiceName);
            entrySaddleMethod.ReadDefintion();

            lineSaddleTag.InitTagDataProvider(constData.tagServiceName);
            //把表中的tag名称赋值到控件中
            foreach (Control control in panelAutoScroll.Controls)
            {
                //添加解锁鞍座控件
                if (control is CoilUnitSaddleButton)
                {
                    CoilUnitSaddleButton t = (CoilUnitSaddleButton)control;
                    if (exitSaddleMethod.DicSaddles.ContainsKey(t.MySaddleNo))
                    {
                        UnitSaddleBase theSaddleInfo = exitSaddleMethod.DicSaddles[t.MySaddleNo];
                        if (!string.IsNullOrEmpty(theSaddleInfo.TagAdd_LockRequest) && theSaddleInfo.TagAdd_LockRequest != "")
                        {
                            t.MySaddleTagName_Feedback = theSaddleInfo.TagAdd_LockRequest_FEEDBACK;
                            t.MySaddleTagName_Set = theSaddleInfo.TagAdd_LockRequest_SET;
                            lineSaddleTag.AddTagName(theSaddleInfo.TagAdd_LockRequest_SET);
                            lineSaddleTag.AddTagName(theSaddleInfo.TagAdd_LockRequest_FEEDBACK);
                        }
                    }
                    else if(entrySaddleMethod.DicSaddles.ContainsKey(t.MySaddleNo))
                    {
                        UnitSaddleBase theSaddleInfo = entrySaddleMethod.DicSaddles[t.MySaddleNo];
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
                if (control is CoilUnitStatus)
                {
                    CoilUnitStatus t = (CoilUnitStatus)control;
                    if (!string.IsNullOrEmpty(t.MyStatusTagName) && t.MyStatusTagName != "")
                    {
                        lineSaddleTag.AddTagName(t.MyStatusTagName);
                    }
                }
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

            exitSaddleInfo.getExitSaddleDt(dgvExitSaddleInfo, Chain);
            entrySaddleInfo.getEntrySaddleDt(dgvEntrySaddleInfo, Chain);
            //是否开启定时器
            timer_LineSaddleControl.Enabled = true;
            //设定刷新时间
            timer_LineSaddleControl.Interval = 5000;
        }
        private void getSaddleMessage()
        {
            exitSaddleMethod.ReadDefintion();
            exitSaddleMethod.getTagNameList();
            exitSaddleMethod.getTagValues();

            entrySaddleMethod.ReadDefintion();
            entrySaddleMethod.getTagNameList();
            entrySaddleMethod.getTagValues();

            foreach (string theL2SaddleName in dicSaddleControls.Keys)
            {
                if (exitSaddleMethod.DicSaddles.ContainsKey(theL2SaddleName))
                {
                    CoilUnitSaddle conSaddle = dicSaddleControls[theL2SaddleName];

                    UnitSaddleBase theSaddleInfo = exitSaddleMethod.DicSaddles[theL2SaddleName];

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
                else if(entrySaddleMethod.DicSaddles.ContainsKey(theL2SaddleName))
                {
                    if (entrySaddleMethod.DicSaddles.ContainsKey(theL2SaddleName))
                    {
                        CoilUnitSaddle conSaddle = dicSaddleControls[theL2SaddleName];

                        UnitSaddleBase theSaddleInfo = entrySaddleMethod.DicSaddles[theL2SaddleName];

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

            exitSaddleInfo.getExitSaddleDt(dgvExitSaddleInfo, Chain);
            entrySaddleInfo.getEntrySaddleDt(dgvEntrySaddleInfo, Chain);

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

        private void coilUnitSaddle_PCQ08Z0_Load(object sender, EventArgs e)
        {

        }

        private void coilUnitSaddle_PCQ07Z0_Load(object sender, EventArgs e)
        {

        }

        private void coilUnitSaddleButton_PCQ16Z0_Load(object sender, EventArgs e)
        {

        }
    }
}
