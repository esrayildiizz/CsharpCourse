using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        //veritanabı ile c# birbirine bağlamak için ya ado.net teknolojisini kullanırız. 
        //ya da entity fremework  teknolojisini kullanırız.

        //ado.net veritanabı ile c# arasında veri işlemlerini yapmak için bir köprü görevi görür.
        //using system data
        //using system data sqlclient  
        //bu kütüphaneleri eklememiz gerekiyor.

        //sqlconnection:veritanabı bağlantı cümlelerini yazmamız sağlar.
        //sqlcommand :veritanabı kodlarını sorgularını yazmamızısağlar
        //sqldatareader :veritanabında veri çekmek için

        //sqldataadapter:verileri çekmek için aracı olur.
        //verileri alır Datatable ve datasetlerimizin içerisinde düzenli bir şekilde aktarılmasını sağlar.

        //Executenonquery method: işlemlerin çalışmasını yürütülmesini sağlar.

        SqlConnection con = new SqlConnection("Server=10.22.0.23;Database=Banka04;Integrated Security=true;"); //veritanabıyla aramızdaki iletişimi sağlıyor.

        private void Urunler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Listele butonu
        {
            GetirListele();
        }


        public void GetirListele()
        {
            SqlCommand cmd = new SqlCommand(); //komut yazmak için sqlcommand'ı kullanırız.
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UListele";


            SqlDataAdapter da = new SqlDataAdapter(cmd); //verileri çek.
            DataTable dt = new DataTable(); //datatable ile düzenli şekilde getir.
            da.Fill(dt);
            dataGridView1.DataSource = dt;  //datagridview da bunları göster diyor.
        }



        private void button2_Click(object sender, EventArgs e) //Kaydet butonu
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(); //komut yazmak için sqlcommand'ı kullanırız.
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UEkle";
            cmd.Parameters.AddWithValue("UrunAdi", textBox2.Text);
            cmd.Parameters.AddWithValue("Marka", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("Model", textBox3.Text);
            cmd.Parameters.AddWithValue("Renk", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("Fiyat", textBox4.Text);
            cmd.ExecuteNonQuery(); //buradaki komut satırlarını döndür ve çalıştır.
            con.Close();
            GetirListele();
        }

        private void button3_Click(object sender, EventArgs e) //Yenile butonu
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(); //komut yazmak için sqlcommand'ı kullanırız.
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UYenile";
            cmd.Parameters.AddWithValue("UrunNO", textBox1.Text);
            cmd.Parameters.AddWithValue("UrunAdi", textBox2.Text);
            cmd.Parameters.AddWithValue("Marka", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("Model", textBox3.Text);
            cmd.Parameters.AddWithValue("Renk", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("Fiyat", textBox4.Text);
            cmd.ExecuteNonQuery(); //buradaki komut satırlarını döndür ve çalıştır.
            con.Close();
            GetirListele();
        }

        private void button4_Click(object sender, EventArgs e) //sil butonu
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(); //komut yazmak için sqlcommand'ı kullanırız.
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "USil";
            cmd.Parameters.AddWithValue("UrunNO", textBox1.Text);
            cmd.ExecuteNonQuery(); //buradaki komut satırlarını döndür ve çalıştır.
            con.Close();
            GetirListele();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            comboBox1.SelectedItem= dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();

        }
    }
}

