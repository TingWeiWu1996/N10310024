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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         // MessageBox.Show("我被點擊了");
            Form form_Button = new Form_Button();
            form_Button.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form midExam = new MidExam();
            midExam.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form button3 = new _123();
            button3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form button4 = new FormTimer();
            button4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form_Panel();
            form.Show();
        }
    }
}
