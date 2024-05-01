using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radioBtn;
            if (radioButton1.Checked == true)
            {
                radioBtn = "radioButton1";
            }
            else
            {
                radioBtn = "radioButton2";
            }

            outPutLabel.Text = "TextBox: " + textBox1.Text + "; " + "ComboBox: " + comboBox1.Text + "; " + "ListBox: " + listBox1.Text + "; " + "RadioBtn: " + radioBtn;
        }

        private void outPutLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
