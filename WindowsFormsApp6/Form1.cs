using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(textBox4.Text);
            int vergi = Convert.ToInt32(textBox5.Text);
            int tutar = fiyat * vergi;

            listBox1.Items.Add("Ödemeniz gereken tutar: " + tutar);

            listBox2.Items.Add("Arabanın Markası:" + textBox1.Text);
            listBox2.Items.Add("Arabanın Markası:" + textBox2.Text);
            listBox2.Items.Add("Arabanın Markası:" + textBox3.Text);
            listBox2.Items.Add("Fiyat:" + textBox4.Text);
            listBox2.Items.Add("Vergi:" + textBox5.Text);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
