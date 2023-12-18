using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = macchina.acc(b,a);
            if (b == -1) textBox2.Text = "";
            else textBox2.Text = Convert.ToString(b)+" km/h";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b=macchina.dec(b, a);
            if (b == -1) textBox2.Text = "";
            else textBox2.Text = Convert.ToString(b) + " km/h";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c=macchina.innesto(c,a);
            if (c == -1) textBox3.Text = "";
            else textBox3.Text = Convert.ToString(c) + "°";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c=macchina.scalare(c,a);
            if (c == -1) textBox3.Text = "";
           else textBox3.Text = Convert.ToString(c) + "°";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=macchina.onOf(a);
            if (a == true)
            {
                textBox1.Text = "ACCESO";
                textBox2.Text = "0 km/h";
                textBox3.Text = "1°";
            }
            else 
            { 
                textBox1.Text = "SPENTO";
                textBox2.Text = "";
                textBox3.Text = "";
            }
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

        public int acc(int b,bool a)
        {
            if (a == true)
            {
                b += 1;
                if (b > 270) b = 270;
                return b;
            }
            else return -1;
            
        }

        public int dec(int b,bool a)
        {
            if (a == true)
            {
                b -= 1;
                if (b < 0) b = 0;
                return b;
            }
            else return -1;
        }

        public int innesto(int c, bool a)
        {
            if (a == true)
            {
                c += 1;
                if (c > 6) c = 6;
                return c;
            }
            else return -1;
        }

        public int scalare(int c,bool a)
        {
            if (a == true)
            {
                c -= 1;
                if (c < 0) c = 0;
                return c;
            }
            else return -1;
        }
    }
}
