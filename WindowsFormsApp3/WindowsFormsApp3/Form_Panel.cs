using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp3
{
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
            if (!File.Exists("OrferData.csv"))
                File.AppendAllText("OrderData.csv", "時間,主食,配餐\n", Encoding.UTF8);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string sideFood = "";

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                        mainFood += c.Text + " ";
                  
                }
            }


            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                        sideFood += c.Text + " ";


                }
            }
          
            DateTime currentDateTime = DateTime.Now;
            string formateDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");

            File.AppendAllText("OrderData.csv", formateDateTime + "," + mainFood + "," + sideFood + "\n");
            MessageBox.Show("點餐成功!");
        }


        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
