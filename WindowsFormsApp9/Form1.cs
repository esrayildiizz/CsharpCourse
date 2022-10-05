using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
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
            go.listBox1.Items.Add("Müşterinin Adı: " + textBox1.Text);
            go.listBox1.Items.Add("Müşterinin Soyadı: " + textBox2.Text);
            go.listBox1.Items.Add("Ödeme Şekli: " +comboBox1.SelectedItem);
            go.listBox1.Items.Add("Sipariş no: " + textBox3.Text);
            go.listBox1.Items.Add("Telefon: " + maskedTextBox1.Text);
            go.listBox1.Items.Add("Adres: " + textBox4.Text);

            go.listBox2.Items.Add("Yiyecek: " + comboBox2.SelectedItem);
            go.listBox2.Items.Add("İçecek: " + comboBox3.SelectedItem);

            if (checkBox1.Checked == true )
            {   
               go.listBox2.Items.Add("Lahmacun Seçimi: " + checkBox1.Text);
               int lahmacunfiyat = Convert.ToInt32(textBox5.Text);
               int lahmacunadet = Convert.ToInt32(textBox8.Text);
               int tutar1 = lahmacunadet * lahmacunfiyat;
               go.listBox2.Items.Add("Lahmacun için ödemeniz gereken tutar: " + tutar1 + " -İçecek ikramımızdır.");
            }
            else if (checkBox2.Checked == true)
            {
                go.listBox2.Items.Add("Lahmacun Seçimi: " + checkBox2.Text);
                int lahmacunfiyat = Convert.ToInt32(textBox5.Text);
                int lahmacunadet = Convert.ToInt32(textBox8.Text);
                int tutar1 = lahmacunadet * lahmacunfiyat;
                go.listBox2.Items.Add("Lahmacun için ödemeniz gereken tutar: " + tutar1 + " -İçecek ikramımızdır.");
            }
            else if (checkBox3.Checked == true)
            {
              go.listBox2.Items.Add("Pizza Seçimi: " + checkBox3.Text);
              int pizzafiyat = Convert.ToInt32(textBox6.Text);
              int pizzaadet = Convert.ToInt32(textBox9.Text);
              int tutar2 = pizzaadet * pizzafiyat;
              go.listBox2.Items.Add("Pizza için ödemeniz gereken tutar: " + tutar2 + " -İçecek ikramımızdır.");
            }
            else if (checkBox4.Checked == true)
            {
                go.listBox2.Items.Add("Pizza Seçimi: " + checkBox4.Text);
                int pizzafiyat = Convert.ToInt32(textBox6.Text);
                int pizzaadet = Convert.ToInt32(textBox9.Text);
                int tutar2 = pizzaadet * pizzafiyat;
                go.listBox2.Items.Add("Pizza için ödemeniz gereken tutar: " + tutar2 + " -İçecek ikramımızdır.");
            }
            else if (checkBox6.Checked == true  )
            {
               go.listBox2.Items.Add("Kebap Seçimi: " + checkBox6.Text);
               int kebapfiyat = Convert.ToInt32(textBox7.Text);
               int kebapadet = Convert.ToInt32(textBox10.Text);
               int tutar3 = kebapadet * kebapfiyat;
               go.listBox2.Items.Add("Kebap için ödemeniz gereken tutar: " + tutar3 + " -İçecek ikramımızdır.");
            }
            else if(checkBox7.Checked == true)
            {
                go.listBox2.Items.Add("Kebap Seçimi: " + checkBox7.Text);
                int kebapfiyat = Convert.ToInt32(textBox7.Text);
                int kebapadet = Convert.ToInt32(textBox10.Text);
                int tutar3 = kebapadet * kebapfiyat;
                go.listBox2.Items.Add("Kebap için ödemeniz gereken tutar: " + tutar3 + " -İçecek ikramımızdır.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedItem.ToString() == "Lahmacun")
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }
            else if (comboBox2.SelectedItem.ToString() == "Pizza")
            {
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
