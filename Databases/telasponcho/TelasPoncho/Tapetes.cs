using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasPoncho
{
    public partial class Tapetes : Form
    {
        public bool checkBoxVar1 = false;
        public bool checkBoxVar2 = false;
        public bool checkBoxVar3 = false;

        public Tapetes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxVar1 == false)
            {
                checkBoxVar1 = true;
                label1.Text = "true";
            }
            else
            {
                checkBoxVar1 = false;
                label1.Text = "false";
            }
        }
    }
}
