using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当鼠标进入按键的可见部分的时候，给按键一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度就是窗体的宽度减去按键的宽度
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;

            Random r = new Random();
            //要给按键一个随机的坐标
            button2.Location = new Point(r.Next(0,x+1),r.Next(0,y+1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟思密达");
            this.Close();//关闭当前主窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你这个屌丝点到了");
            this.Close();
        }


      
    }
}
