using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int LeftDog, LeftRabbit, LeftHorse;
        Random rnd = new Random();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        




        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox1.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label4.Visible = false;
            pictureBox4.Visible = false;
            comboBox1.Visible = false;
            button2.Visible = false;
            pictureBox5.Size = new Size(223, 186);
            pictureBox5.Location = new Point(1100, 320);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string texmin = comboBox1.Text;
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            int widthHorse = pictureBox1.Width;
            int widthRabbit = pictureBox2.Width;
            int widthDog = pictureBox3.Width;
            int start = label7.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(0, 5);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(0, 5);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(0, 5);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "At Birincidir";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Canavar Irelileyir";
            }


            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "It birinci oldu";
            }

            if (widthHorse + pictureBox1.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "At Yarisi Qazandi";
            }
            if (widthHorse + pictureBox1.Left >= start && texmin == "At")
            {

                MessageBox.Show(ad + soyad + "Siz Qazandiniz");
            }
            if (label6.Text == "At Yarisi Qazandi" && texmin != "At")
            {
                MessageBox.Show(ad + soyad + "Siz Qazanmadiniz");

            }
            if (widthRabbit + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "Canavar Yarisi Qazandi";
            }

            if (widthRabbit + pictureBox2.Left >= start && texmin == "Canavar")
            {
                MessageBox.Show(ad + soyad + "Siz Qazandiniz");
            }
            if (label6.Text == "Canavar Yarisi Qazandi" && texmin != "Canavar")
            {
                MessageBox.Show(ad + soyad + "Siz Qazanmadiniz");

            }
            if (widthDog + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "It Yarisi Qazandi";
            }
            if (widthDog + pictureBox3.Left >= start && texmin == "It")
            {
                MessageBox.Show(ad + soyad + "Siz Qazandiniz");
            }
            if (label6.Text == "It Yarisi Qazandi" && texmin != "It")
            {
                MessageBox.Show(ad + soyad + "Siz Qazanmadiniz");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LeftHorse = pictureBox1.Left;
            LeftRabbit = pictureBox2.Left;
            LeftDog = pictureBox3.Left;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     





        }
    }
}
