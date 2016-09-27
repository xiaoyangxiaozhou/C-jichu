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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 关闭主窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //需要获取当前主窗体的对象,在此调用Close不显示，但调用show可以？
            //Form1 frm1 = new Form1();
            //frm1.Close();
            //Form2 form2 = new Form2();
            //form2.Close();
            //Form3 form3 = new Form3();
            //form3.Show();

            //调用主窗体1
            Test._fr1Test.Close();

        }
    }
}
