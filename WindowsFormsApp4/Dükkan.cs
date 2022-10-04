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
    public partial class Dükkan : Form
    {
        public Dükkan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = 600000;
            MessageBox.Show("Ödemeniz gereken tutar : " + fiyat.ToString());

        }
    }
}
