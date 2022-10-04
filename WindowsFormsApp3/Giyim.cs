using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Giyim : Form
    {
        public Giyim()
        {
            InitializeComponent();
        }

        private void Giyim_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Erkek")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Kadın")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }
        
    }
}
