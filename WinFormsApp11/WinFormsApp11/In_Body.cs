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

namespace WinFormsApp11
{
    public partial class In_Body : Form
    {
        public In_Body()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 back = new Form1();
            this.Hide();
            back.ShowDialog();
            this.Close();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            float age = float.Parse(textBox1.Text);
            float hieght = float.Parse(textBox3.Text);
            float wieght = float.Parse(textBox2.Text);




            string gender = comboBox1.SelectedItem.ToString();
            if (gender == "Male")
            {


                float fat_per = 1.2f * 10000f * (wieght / (hieght * hieght)) + (0.23f * age) - 16.2f;
                float water_per = (((wieght * 0.3362f) + (hieght * 0.1074f) - (age * 0.09145f) + 2.447f) / wieght) * 100f;
                float bmi = 10000f * (wieght / (hieght * hieght));
                float bmr = 88.362f + 13.397f * wieght + 4.799f * hieght - 5.677f * age;
                bmi = (float)System.Math.Round(bmi, 2);
                bmr = (float)System.Math.Round(bmr, 2);
                fat_per = (float)System.Math.Round(fat_per, 2);
                water_per = (float)System.Math.Round(water_per, 2);
                //
                textBox4.Text = fat_per.ToString() + "%" + "  (11-22)";
                textBox5.Text = water_per.ToString() + "%" + "  (52-57)";
                textBox6.Text = bmi.ToString() + "  (21-24)";
                textBox7.Text = bmr.ToString() + "  (1170-2440)";

            }
            else
            {
                float fat_per = 1.2f * 10000f * (wieght / (hieght * hieght)) + (0.23f * age) - 5.4f;
                float water_per = (((wieght * 0.2466f) + (hieght * 0.1069f) + (age * 0.09145f) - 2.097f) / wieght) * 100;
                float bmi = 10000 * (wieght / (hieght * hieght));
                float bmr = 447.593f + 9.247f * wieght + 3.098f * hieght - 4.33f * age;
                //
                bmi = (float)System.Math.Round(bmi, 2);
                bmr = (float)System.Math.Round(bmr, 2);
                fat_per = (float)System.Math.Round(fat_per, 2);
                water_per = (float)System.Math.Round(water_per, 2);

                textBox4.Text = fat_per.ToString() + "%" + "  (18-28)";
                textBox5.Text = water_per.ToString() + "%" + "  (52-55)";
                textBox6.Text = bmi.ToString() + "  (18.5-25)";
                textBox7.Text = bmr.ToString() + "  (1800-2000)";




            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rb1_Click(object sender, EventArgs e)
        {

        }

        private void In_Body_Load(object sender, EventArgs e)
        {

        }
    }
}

