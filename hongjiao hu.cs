using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hongjiao_hu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            asd.Text = "good";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            asd.Text = "bad";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            asd.Text = "ture";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            asd.Text = "flase";
        }

        private void bigbox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            asd.Text = "correct";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            asd.Text = "incorrect";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asd.Text = "good";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            asd.Text = "bad";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asd.Text = "ture";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asd.Text = "flase";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            asd.Text = "correct";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            asd.Text = "incorrect";
        }
    }
}
