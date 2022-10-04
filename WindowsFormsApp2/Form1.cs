using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(textBox2.Text);
            int adet = Convert.ToInt32(textBox3.Text);
            int sonuc = fiyat * adet;
            MessageBox.Show(textBox1.Text + " ürününüzün toplam fiyatı: " + sonuc);
        }
    }
}
