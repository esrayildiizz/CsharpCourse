using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Kiralık : Form
    {
        public Kiralık()
        {
            InitializeComponent();
        }

        private void Kiralık_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = 4000;
            MessageBox.Show("Ödemeniz gereken tutar : " + fiyat.ToString());
        }
    }
}
