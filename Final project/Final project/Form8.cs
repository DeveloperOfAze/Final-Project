using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                string secim = comboBox1.Text;
                int qiymet = Convert.ToInt32(textBox1.Text);
                float sufaizi = 0.2f;
                float edvfaiz = 0.18f;
                float suedvsi = Convert.ToSingle(qiymet) * sufaizi * edvfaiz;
                float etfaiz = 0.3f;
                float etedvsi = Convert.ToSingle(qiymet) * etfaiz * edvfaiz;
                float kitabxana = 0.1f;
                float kitabxanaedvsi = Convert.ToSingle(qiymet) * kitabxana * edvfaiz;


                if (secim == "Su")
                {
                    MessageBox.Show(Convert.ToString(suedvsi));
                }
                if (secim == "Et")
                {
                    MessageBox.Show(Convert.ToString(etedvsi));
                }
                if (secim == "Un")
                {
                    MessageBox.Show("Un Mehsuluna Edv Verilmir");

                }
                if (secim == "Kitabxana")
                {
                    MessageBox.Show(Convert.ToString(kitabxanaedvsi));
               
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
