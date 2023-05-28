using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormTimer : Form
    {
        int second = 0;
        int count1 = 0;
        int count2 = 0;
        public FormTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = this.second + "秒"; //test
            this.second++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count2 = 0;
            label2.Text = String.Format("{0}秒", count2.ToString());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0}秒", count2.ToString());
            count2++;
          
        }
    }
}
