using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
            this.Hide();
            go.listBox1.Items.Add("Adınız Soyadınız: " + textBox1.Text);
            go.listBox1.Items.Add("Yaşınız: " + textBox2.Text);
            go.listBox1.Items.Add("Adres: " + textBox3.Text);
            go.listBox1.Items.Add("Cinsiyet: " + comboBox1.SelectedItem);

        }
    }
}
