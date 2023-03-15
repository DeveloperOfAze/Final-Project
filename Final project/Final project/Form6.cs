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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usrname = "Ehed";
            string kod = "Ehed123";
            string gelenad = textBox1.Text;
            string gelenpass = textBox2.Text;
            if(usrname == gelenad && kod==gelenpass)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            if(usrname != gelenad && kod == gelenpass)
            {
                MessageBox.Show("Username Sehvdir");
            }
            if (usrname == gelenad && kod != gelenpass)
            {
                MessageBox.Show("Sifre Sehvdir");
            }
            if (usrname != gelenad && kod != gelenpass)
            {
                MessageBox.Show("Melumatlar  Sehvdir");
            }
        }
    }
}
