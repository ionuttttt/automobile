using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automobile
{
    public partial class Form1 : Form
    {
        macchina macchina = new macchina();
        bool a = false;
        int b=0,c=0;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "SPENTO";
            textBox2.Text = "0 km/h";
            textBox3.Text = "1°";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = macchina.acc(b);
            textBox2.Text = Convert.ToString(b)+" km/h";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=macchina.onOf(a);
            if (a == true)
            {
                textBox1.Text = "ACCESO";
            }
            else { textBox1.Text = "SPENTO"; }
        }


    }
    class macchina
    {
        protected bool a { get; set; }
        protected int b { get; set; }
        protected int c { get; set; }


        public bool onOf(bool a)
        {

            if (a == false)
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }

        public int acc(int b)
        {
            b += 1;
            return b;
        }
    }
}
