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
    public partial class Form_Button : Form
    {
        public Form_Button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (button1.Text == "請按我一下")
                button1.Text = "我已經被按過了";
            else if  (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鍵被按過";
        }

        private void button3_Click(object sender, EventArgs e)
        {
          string temp = label2.Text;
          int count = 0;
          try
            {
                count = int.Parse(temp) + 1;
            }catch(Exception)
            {
                label2.Text = "0";
            }
            label2.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp = label2.Text;
            int count = 0;
            try
            {
                count = int.Parse(temp) - 1;
            }
            catch (Exception)
            {
                label2.Text = "0";
            }
            label2.Text = count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            short sizeNum = 10;
            button5.Size= new Size(button5.Width+sizeNum, button5.Height+sizeNum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form_TextBox = new Form_TextBox();
            form_TextBox.Show();
        }
    }
}
