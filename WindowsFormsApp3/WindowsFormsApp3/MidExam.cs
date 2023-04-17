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
    public partial class MidExam : Form
    {
        public MidExam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            string str = textBox1.Text;
            double input = Int32.Parse(str);
            lab_result.Text = (input  *(9 / 5.0) + 32) .ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MidExam_Load(object sender, EventArgs e)
        {

        }
    }
}
