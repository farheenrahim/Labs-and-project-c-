using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name,messagetext;
            messagetext = "welcome:";
            name = textBox2.Text;
            textBox1.Text = messagetext+name;
            label2.Text = messagetext+name;    
        }
    }
}
