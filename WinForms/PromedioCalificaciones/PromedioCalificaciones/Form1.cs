using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioCalificaciones
{
    public partial class Form1 : Form
    {
        public bool checkBoxValue1 = false;
        public bool checkBoxValue2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  label3.Text = "Guevara";      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        //    label2.Text = "Octavio";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxValue1 == false)
            {
                checkBoxValue1 = true;
                checkBox1.Text = "true";
            }
            else
            {
                checkBoxValue1 = false;
                checkBox1.Text = "false";
            }
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
