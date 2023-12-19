using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class calorise_in_food : Form
    {
        public double tx1;
        public double tx2;
        public double tx3;
        public double tx4;
        public double tx5;
        public double tx6;
        public double tx7;
        public double tx8;
        public double tx9;


        public double meat;
        public double chicken;
        double rice;
        double pasta;
        double milk;
        double banana;
        double eggs;
        double apple;
        double bread;
        public calorise_in_food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = textBox1.Text;
            tx1 = double.Parse(a);
            meat = (tx1 / 100) * 250;
            textBox10.Text = meat.ToString();


            string b = textBox2.Text;
            tx2 = double.Parse(b);
            chicken = (tx2 / 100) * 224;
            textBox11.Text = chicken.ToString();


            string c = textBox3.Text;
            tx3 = double.Parse(c);
            rice = (tx3 / 100) * 200;
            textBox12.Text = rice.ToString();


            string d = textBox4.Text;
            tx4 = double.Parse(d);
            pasta = (tx4 / 100) * 158;
            textBox13.Text = pasta.ToString();

            string w = textBox5.Text;
            tx5 = double.Parse(w);
            milk = (tx5 / 100) * 65;
            textBox14.Text = milk.ToString();

            string f = textBox6.Text;
            tx6 = double.Parse(f);
            banana = (tx6 / 1) * 100;
            textBox15.Text = banana.ToString();

            string g = textBox7.Text;
            tx7 = double.Parse(g);
            bread = (tx7 / 1) * 255;
            textBox16.Text = bread.ToString();


            string h = textBox8.Text;
            tx8 = double.Parse(h);
            eggs = (tx8 / 1) * 72;
            textBox17.Text = eggs.ToString();


            string i = textBox9.Text;
            tx9 = double.Parse(i);
            apple = (tx9 / 1) * 100;
            textBox18.Text = apple.ToString();


            double sum = 0;
            // textBox7.Text = sum.ToString();

            // total calories result from net calories
            if (double.TryParse(textBox10.Text, out double value1))
            {
                sum += value1;
            }

            if (double.TryParse(textBox11.Text, out double value2))
            {
                sum += value2;
            }

            if (double.TryParse(textBox12.Text, out double value3))
            {
                sum += value3;
            }
            if (double.TryParse(textBox13.Text, out double value4))
            {
                sum += value4;
            }
            if (double.TryParse(textBox14.Text, out double value5))
            {
                sum += value5;
            }
            if (double.TryParse(textBox15.Text, out double value6))
            {
                sum += value6;
            }
            if (double.TryParse(textBox16.Text, out double value7))
            {
                sum += value7;
            }
            if (double.TryParse(textBox17.Text, out double value8))
            {
                sum += value8;
            }
            if (double.TryParse(textBox18.Text, out double value9))
            {
                sum += value9;
            }

            textBox19.Text = sum.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void calorise_in_food_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 back3 = new Form1();
            this.Hide();
            back3.ShowDialog();
            this.Close();
        }
    }
}
