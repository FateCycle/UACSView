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
using UACSControls;
using System.Media;
using UACSPopupForm;
using Baosight.iSuperframe.Forms;
using System.Reflection;


namespace UACSControls
{
    public partial class UserMessageShow : UserControl
    {
     
        public UserMessageShow()
        {
            InitializeComponent();
        }


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

        //step1
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
            { }
        }


        //step2
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
        public void RefreshControl02(CraneStatusBase theCraneStatusBase)
        {
            try
            {

                craneStatusBase = theCraneStatusBase;
               craneinfo.craneOrderInfo02(craneStatusBase.CraneNO.ToString(), txt_ORDER_TYPE, txt_MAT_NO_1, txt_MAT_NO_2, txt_TO_STOCK_NO, txt_FROM_STOCK_NO);
            }
            catch
            {


            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserMessageShow_Load(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
           
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

        private void txt_ORDER_TYPE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
