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
    public partial class UserMessage : UserControl
    {


        public UserMessage()
        {
            InitializeComponent();
          

        }

    
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
        public void RefreshControl01(CraneStatusBase theCraneStatusBase)
        {
            try
            {

                craneStatusBase = theCraneStatusBase;

                ///安全门1
               // lab1 .Text =  craneStatusBase.Safe_door1.ToString();
                if(craneStatusBase.Safe_door1.ToString()=="1")
                {
                    this.lab1.BackColor = System.Drawing.Color.Red;
                    this.lab1.ForeColor = System.Drawing.Color.White;
                    this.lab1.Text = "开";
                }
                else if(craneStatusBase.Safe_door1.ToString() == "0")
                {
                    this.lab1.BackColor = System.Drawing.Color.Lime;
                    this.lab1.ForeColor = System.Drawing.Color.Black;
                    this.lab1.Text = "关";
                }
                else
                {
                    this.lab1.BackColor = System.Drawing.Color.Red;
                    this.lab1.ForeColor = System.Drawing.Color.White;
                    this.lab1.Text = "未知";

                }
                ///安全门2
               // lab2.Text = craneStatusBase.Safe_door2.ToString();
                if (craneStatusBase.Safe_door2.ToString() == "1")
                {
                    this.lab2.BackColor = System.Drawing.Color.Red;
                    this.lab2.ForeColor = System.Drawing.Color.White;
                    this.lab2.Text = "开";
                }
                else if (craneStatusBase.Safe_door2.ToString() == "0")
                {
                    this.lab2.BackColor = System.Drawing.Color.Lime;
                    this.lab2.ForeColor = System.Drawing.Color.Black;
                    this.lab2.Text = "关";
                }
                else
                {
                    this.lab2.BackColor = System.Drawing.Color.Red;
                    this.lab2.ForeColor = System.Drawing.Color.White;
                    this.lab2.Text = "未知";

                }
                ///安全门3
                //lab3.Text = craneStatusBase.Safe_door3.ToString();
                if (craneStatusBase.Safe_door3.ToString() == "1")
                {
                    this.lab3.BackColor = System.Drawing.Color.Red;
                    this.lab3.ForeColor = System.Drawing.Color.White;
                    this.lab3.Text = "开";
                }
                else if (craneStatusBase.Safe_door3.ToString() == "0")
                {
                    this.lab3.BackColor = System.Drawing.Color.Lime;
                    this.lab3.ForeColor = System.Drawing.Color.Black;
                    this.lab3.Text = "关";
                }
                else
                {
                    this.lab3.BackColor = System.Drawing.Color.Red;
                    this.lab3.ForeColor = System.Drawing.Color.White;
                    this.lab3.Text = "未知";

                }
                ///安全门4
             //   lab4.Text = craneStatusBase.Safe_door4.ToString();
                if (craneStatusBase.Safe_door4.ToString() == "1")
                {
                    this.lab4.BackColor = System.Drawing.Color.Red;
                    this.lab4.ForeColor = System.Drawing.Color.White;
                    this.lab4.Text = "开";
                }
                else if (craneStatusBase.Safe_door4.ToString() == "0")
                {
                    this.lab4.BackColor = System.Drawing.Color.Lime;
                    this.lab4.ForeColor = System.Drawing.Color.Black;
                    this.lab4.Text = "关";
                }
                else
                {
                    this.lab4.BackColor = System.Drawing.Color.Red;
                    this.lab4.ForeColor = System.Drawing.Color.White;
                    this.lab4.Text = "未知";

                }
            }
            catch
            {


            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserMessage_Load(object sender, EventArgs e)
        {

          
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
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

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void la4_Click(object sender, EventArgs e)
        {

        }
    }
}
