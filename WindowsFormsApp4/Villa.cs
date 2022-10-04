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
    public partial class Villa : Form
    {
        public Villa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = 4000000;
            MessageBox.Show("Ödemeniz gereken tutar : " + fiyat.ToString());
        }
    }
}
