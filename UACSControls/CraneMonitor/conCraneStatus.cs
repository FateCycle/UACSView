using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UACSDAL;
using Baosight.iSuperframe.Common;
using Baosight.iSuperframe.Authorization.Interface;
using System.Media;
using UACSPopupForm;
using System.Net;
using UACSDAL.CraneMonitor;

namespace UACSControls
{
   
    public partial class conCraneStatus : UserControl
    {
        public const long SHORT_CMD_NORMAL_STOP = 100;
        public const long SHORT_CMD_EMG_STOP = 200;
        public const long SHORT_CMD_RESET = 300;
        public const long SHORT_CMD_ASK_COMPUTER_AUTO = 400;
        public const long SHORT_CMD_CANCEL_COMPUTER_AUTO = 500;
       
        private FrmModeSwitchover frmModeSwitchover = null;
        private PlaySoundHandler playSound = null;
        private CraneStatusInBay craneinfo = null;

        private bool flag = false;

        private Baosight.iSuperframe.TagService.Controls.TagDataProvider tagDataProvider = null;


        System.Object locker = new System.Object();
        public conCraneStatus()
        {
            InitializeComponent();

        }


        private string TagServiceName = string.Empty;
        //step1
        public void InitTagDataProvide(string tagServiceName)
        {
            try
            {
                tagDataProvider = new Baosight.iSuperframe.TagService.Controls.TagDataProvider();
                this.TagServiceName = tagServiceName;
                tagDataProvider.ServiceName = TagServiceName;
                craneinfo = new CraneStatusInBay();
                playSound += new PlaySoundHandler(PlaySoundEvt);
            }
            catch (Exception ex)
            {}
        }


        private string craneNO = string.Empty;
        //step2
        public string CraneNO
        {
            get { return craneNO; }
            set { craneNO = value; }
        }

        long heatBeatCounter = 0;
        bool communicate_PLC_OK = true;

        private CraneStatusBase craneStatusBase = new CraneStatusBase();
        public delegate void RefreshControlInvoke(CraneStatusBase theCraneStatusBase);
        //step3
        public void RefreshControl(CraneStatusBase theCraneStatusBase)
        {
            try
            {

                craneStatusBase = theCraneStatusBase;

                //行车号
                lbl_CraneNo.Text = "行车 " + craneStatusBase.CraneNO.ToString();
                //准备好信号灯
                refresh_Textbox_Light(light_READY, craneStatusBase.Ready);
                //自动信号灯
                if (craneStatusBase.ControlMode == 4)
                {
                    refresh_Textbox_Light(light_CONTROL_MODE, 1);
                }
                else
                {
                    refresh_Textbox_Light(light_CONTROL_MODE, 0);
                }
                //控制模式
                txt_CONTROL_MODE.Text = craneStatusBase.CraneModeDesc();
                //请求指令信号灯
                refresh_Textbox_Light(light_ASK_PLAN, craneStatusBase.AskPlan);
                //x
                txt_XACT.Text = craneStatusBase.XAct.ToString("0,000");
                //y
                txt_YACT.Text = craneStatusBase.YAct.ToString("0,000");
                //z
                txt_ZACT.Text = craneStatusBase.ZAct.ToString("0,000");
                //有坯信号灯
                refresh_Textbox_Light(light_HAS_COIL, craneStatusBase.HasCoil);
                //行车状态
                txt_CRANE_STATUS.Text = craneStatusBase.CraneStatusDesc();
                //与行车通讯状态
                if (lbl_HeartBeat.Text == craneStatusBase.ReceiveTime.ToString() && communicate_PLC_OK == true)
                {
                    heatBeatCounter++;
                }
                if (lbl_HeartBeat.Text != craneStatusBase.ReceiveTime.ToString() && communicate_PLC_OK == true)
                {
                    heatBeatCounter = 0;
                }
                else if (lbl_HeartBeat.Text != craneStatusBase.ReceiveTime.ToString() && communicate_PLC_OK == false)
                {
                    heatBeatCounter = 0;
                    communicate_PLC_OK = true;
                }

                if (heatBeatCounter >= 20 && communicate_PLC_OK == true)
                {
                    communicate_PLC_OK = false;
                }

                if (communicate_PLC_OK)
                {
                    lbl_HeartBeat.BackColor = Color.LightGreen;
                }
                else
                {
                    lbl_HeartBeat.BackColor = Color.Red;
                }
                //时间心跳
                lbl_HeartBeat.Text = craneStatusBase.ReceiveTime.ToString();
                //行车指令
                craneinfo.craneOrderInfo(craneStatusBase.CraneNO.ToString(),txt_CraneOrder,txt_CoilNo,txt_CoilNo1,txt_FromStock, txt_ToStock,txt_FromStockX,txt_FromStockY,txt_FromStockZ,txt_ToStockX,txt_ToStockY,txt_ToStockZ,txt_ObjectType,txt_CmdStatus,txt_OrderType);

                //if (txt_CONTROL_MODE.Text == "等待" && txt_CRANE_STATUS.Text == "999")
                //{
                //    btnShow.Visible = true;
                //    if (!flag)
                //    {
                //        btnShow.BackColor = Color.Red;
                //        flag = true;
                //    }
                //    else
                //    {
                //        btnShow.BackColor = System.Drawing.SystemColors.Control;
                //        flag = false;
                //    }
                //    timer1.Enabled = true;           
                //}
                //else
                //{
                //    timer1.Enabled = false;
                //    btnShow.Visible = false;
                //}           
            }
            catch (Exception ex)
            {
                LogManager.WriteProgramLog(ex.Message);
                LogManager.WriteProgramLog(ex.StackTrace);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PlaySoundDelegate dge = new PlaySoundDelegate(PlaySoundFuntion);
            dge.BeginInvoke("行车故障.wav", null, null);

        }

        private void PlaySoundFuntion(string fileName)
        {
            if (btnShow.Visible == true)
            {
                SoundEvtAgs e = new SoundEvtAgs();
                e.FileName = fileName;
                playSound(this, e);
            }
        }
        private void PlaySoundEvt(object sender, SoundEvtAgs e)
        {
            playesounder(e.FileName);
        }
        private void playesounder(String strWaveName)
        {
            try
            {
                System.Media.SoundPlayer player = new SoundPlayer();
                player.SoundLocation = System.Windows.Forms.Application.StartupPath + "\\" + strWaveName;
                player.Load();
                player.PlaySync();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }


       
        /// <summary>
        /// 当前状态
        /// </summary>
        /// <param name="theTextBox"></param>
        /// <param name="theValue"></param>
        private static void refresh_Textbox_Light(Panel panel, long theValue)
        {
            try
            {
                if (theValue == 1)
                {
                    panel.BackColor = Color.LightGreen;
                }
                else
                {
                    panel.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {}
        }

        /// <summary>
        /// 紧停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("是否确定紧停"), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SendShortCmd(craneNO, CraneStatusBase.SHORT_CMD_EMG_STOP);
                //获取当前时间
                string MeText = "紧停";
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string HostName = Dns.GetHostName();
                //  Console.WriteLine("主机名是：" + HostName);
                //遍历地址列表，如果电脑有多网卡只能这样遍历显示
                IPAddress[] iplist = Dns.GetHostAddresses(HostName);
                for (int i = 0; i < iplist.Length; i++)
                {
                    string mIp = iplist[i].ToString();
                    // Console.WriteLine("IP地址：" + iplist[i]);
                    string MIPVALUE = mIp.Substring(0, 3);
                    if (MIPVALUE == "192")
                    {
                        try
                        {
                            string sql = @"insert into UACS_HMI_OPER_HISTORY(HOST_IP,ACTION,REC_TIME)values('" + mIp + "','" + MeText + "','" + date + "')";
                            //  string sqlm = @"update UACS_HMI_OPER_HISTORY SET REC_TIME=current timestamp where HOST_IP='" + mIp + "'";
                            DB2Connect.DBHelper.ExecuteNonQuery(sql);
                            //  DB2Connect.DBHelper.ExecuteNonQuery(sqlm);
                        }
                        catch (Exception er)
                        {

                        }
                    }
                }
            }
        }


        /// <summary>
        /// 模式切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMode_Click(object sender, EventArgs e)
        {
            if (frmModeSwitchover == null || frmModeSwitchover.IsDisposed)
            {
                frmModeSwitchover = new FrmModeSwitchover();
                frmModeSwitchover.Crane_No = craneNO;
                frmModeSwitchover.TagServiceName = TagServiceName;
                frmModeSwitchover.Show();
            }
            else
            {
                frmModeSwitchover.WindowState = FormWindowState.Normal;
                frmModeSwitchover.Activate();
            }   
            
        }


        /// <summary>
        /// 模式切换
        /// </summary>
        /// <param name="theCraneNO">行车号</param>
        /// <param name="cmdFlag">对应模式切换数值</param>
        private void SendShortCmd(string theCraneNO, long cmdFlag)
        {
            try
            {
                string messageBuffer = string.Empty;
                messageBuffer = theCraneNO + "," + cmdFlag.ToString();
                Baosight.iSuperframe.TagService.DataCollection<object> wirteDatas = new Baosight.iSuperframe.TagService.DataCollection<object>();
                wirteDatas[theCraneNO + "_DownLoadShortCommand"] = messageBuffer;
                tagDataProvider.SetData(theCraneNO + "_DownLoadShortCommand", messageBuffer);
            }
            catch (Exception ex)
            {

            }
        }


        
        private void btnShow_Click(object sender, EventArgs e)
        {
            PopAlarmCurrent pop = new PopAlarmCurrent();
            pop.Crane_No = craneNO;
            pop.ShowDialog();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_FromStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_XACT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CoilNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txt_OrderType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CRANE_STATUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_HeartBeat_Click(object sender, EventArgs e)
        {

        }

        public void toggle(string tagValue)
        {
            TCraneAlarmJudge craneAlarmJudge = new TCraneAlarmJudge();
            craneAlarmJudge.Crane_No = craneNO;
            if (craneAlarmJudge.isAlarm())
            {
                btnShow.BackColor = Color.Red;
            }
            else
            {
                btnShow.BackColor = Color.White;
            }
        }
    }

    public delegate void PlaySoundHandler(object sender, SoundEvtAgs e);
    public delegate void PlaySoundDelegate(string fileName);
    public class SoundEvtAgs : System.EventArgs
    {
        private string fileName;
        public string FileName
        {
            set { fileName = value; }
            get { return fileName; }
        }
    }
}
