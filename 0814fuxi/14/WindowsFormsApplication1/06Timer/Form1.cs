using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace _06Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0,1);
        }

        /// <summary>
        /// 当加载窗体的时候，将系统当前的时间赋值给label3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 系统时间不断变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
            //18：21分播放音乐叫我起床
            if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 32 && DateTime.Now.Second == 20)
            {
                SoundPlayer sp = new SoundPlayer();//只能播放wav
                sp.SoundLocation = @"C:\Users\hongmf\Desktop\msg.wav";
                sp.Play();
            }
           
        }
    }
}
