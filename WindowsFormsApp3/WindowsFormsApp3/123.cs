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
    public partial class _123 : Form
    {
        public _123()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int add1 = 0, add2 = 0;
            try
            {
                add1 = Int32.Parse(textBox1.Text);
                add2 = Int32.Parse(textBox2.Text);
            }
            catch(SystemException)
            {
                MessageBox.Show("請輸入數字");
                add1 = 0;
                add2 = 0;
            }
            finally
            {
                MessageBox.Show("Try-Catch結束");  
            }

            label3.Text=(add1 + add2).ToString();
        }
    }
}
