using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("hello world");
            this.Close();
        }

       /// <summary>
       /// 弹出窗体2
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void 弹出窗体2(object sender, EventArgs e)
        {
            //在内存中创建窗体2对象
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Test._fr1Test = this;
        }

       
    }
}
