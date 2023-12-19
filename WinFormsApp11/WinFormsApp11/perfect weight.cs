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
    public partial class perfect_weight : Form
    {
        public perfect_weight()
        {
            InitializeComponent();
        }

        private void rb1_Click(object sender, EventArgs e)
        {
            string s;
            double h, w, bmi, min_best_weight, max_best_weight, best_weight;
            h = double.Parse(textBox1.Text);
            h = h / 100;
            w = double.Parse(textBox2.Text);
            bmi = w / (h * h);
            bmi = (double)System.Math.Round(bmi, 1);

            textBox6.Text = (bmi.ToString());
            // int BMI = Convert.ToInt32(bmi);
            min_best_weight = (18.5 * (h * h));
            max_best_weight = (25 * (h * h));
            min_best_weight = (double)System.Math.Round(min_best_weight, 1);
            max_best_weight = (double)System.Math.Round(max_best_weight, 1);


            best_weight = (min_best_weight + max_best_weight) / 2;
            best_weight = (double)System.Math.Round(best_weight, 1);

            if (bmi < 15)
            {
                textBox3.Text = ("نقص حاد جداً في الوزن".ToString());
                // s = "نقص حاد جداً في الوزن";

            }
            else if (bmi >= 15 && bmi < 16)
            {
                textBox3.Text = ("نقص حاد في الوزن".ToString());
            }
            else if (bmi >= 16 && bmi < 18.5)
            {
                textBox3.Text = ("نقص في الوزن".ToString());
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                textBox3.Text = ("وزن طبيعي".ToString());
            }
            else if (bmi >= 25 && bmi < 30)
            {
                textBox3.Text = ("زيادة في الوزن".ToString());
            }
            else if (bmi >= 30 && bmi < 35)
            {
                textBox3.Text = ("سمنة درجة أولى".ToString());
            }
            else if (bmi >= 35 && bmi < 40)
            {
                textBox3.Text = ("سمنة درجة ثانية".ToString());
            }
            else if (bmi >= 40)
            {
                textBox3.Text = ("سمنة مفرطة جداً".ToString());
            }
            textBox5.Text = (best_weight.ToString());
            textBox4.Text = (min_best_weight + " _ " + max_best_weight.ToString());

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 back1 = new Form1();
            this.Hide();
            back1.ShowDialog();
            this.Close();
        }

        private void perfect_weight_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}

