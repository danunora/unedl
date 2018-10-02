using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "textBox1_changed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to be executed during the loading the form phase
            //label1.Text = "Loading Form";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtInput.Text.ToLower();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Cancelar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Aceptar";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ushort numberPeople = 23;
            label1.Text = $"Number of people : {numberPeople}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ushort numberPeople = 34;
            label2.Text = $"Number of people : {numberPeople}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Text = $"This is an Star! : ";

        }
    }
}
