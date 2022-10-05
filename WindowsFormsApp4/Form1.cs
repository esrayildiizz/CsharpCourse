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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satılık go = new Satılık();
            go.Show();
            this.Hide();
        }

        private void daireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kiralık go2 = new Kiralık();
            go2.Show();
            this.Hide();
        }

        private void villaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Villa go3 = new Villa();
            go3.Show();
            this.Hide();
        }

        private void arsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arsa go4 = new Arsa();
            go4.Show();
            this.Hide();
        }

        private void dükkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dükkan go5 = new Dükkan();
            go5.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
