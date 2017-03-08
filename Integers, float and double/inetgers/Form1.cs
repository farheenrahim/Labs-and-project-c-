using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inetgers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 9;
            MessageBox.Show(number.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float myfloat = 1.2345678f;
            MessageBox.Show(myfloat.ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mydouble = 1.23456789;
            MessageBox.Show(mydouble.ToString());
        }
    }
}
