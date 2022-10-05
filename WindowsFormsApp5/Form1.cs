using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("Ehliyet Durumu: " + radioButton1.Text);
            }
            else
            {
                listBox1.Items.Add("Ehliyet Durumu: " + radioButton2.Text);
            }
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Medeni Durumu: " + checkBox1.Text);
            }
            else
            {
                listBox1.Items.Add("Medeni Durumu: " + checkBox2.Text);
            }

            listBox1.Items.Add("Telefon" + maskedTextBox1.Text);
            listBox1.Items.Add("Adet" + numericUpDown1.Text);
            listBox1.Items.Add("Fiyat" + textBox1.Text);

            int fiyat = Convert.ToInt32(textBox1.Text);
            int adet = Convert.ToInt32(numericUpDown1.Text);
            int tutar = fiyat * adet;

            listBox1.Items.Add("Ödemeniz gereken tutar: " + tutar);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
