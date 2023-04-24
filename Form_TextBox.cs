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
    public partial class Form_TextBox : Form
    {
        public Form_TextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int input = Int32.Parse(str);
            lab_result.Text = (input + 10).ToString();
            //MessageBox.Show(str);
        }
    }
}
