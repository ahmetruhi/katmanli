using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracIslem
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = null;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        void MusteriGetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=ntp_arac");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM arac", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMark.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPlak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            //    {
            //        using (SqlCommand cmd = new SqlCommand("Insert into tblOgrenciler arac(@Ad,@Soyad,@Numara)", baglanti))
            //        {
            //            SqlParameter[] p = { new SqlParameter("@marka", txtMark.Text), new SqlParameter("model", txtModel.Text), new SqlParameter("@no", txtNo.Text), new SqlParameter("@plaka", txtPlak.Text), new SqlParameter("@tarih", Convert.ToDateTime(txtTarih.Text)) };

            //            cmd.Parameters.AddRange(p);

            //            if (baglanti != null && baglanti.State != ConnectionState.Open)
            //            {
            //                baglanti.Open();
            //            }
            //        }

            //    }
            //}
            //catch (Exception)
            //{
            //    throw;

            //}



            string ekle = "INSERT INTO arac(marka,model,no,plaka,tarih) VALUES (@marka,@model,@no,@plaka,@tarih) "; //(marka,model,plaka,tarih)
            komut = new SqlCommand(ekle, baglanti);
            //SqlParameter[] p = { new SqlParameter("@marka", txtMark.Text), new SqlParameter("@model", txtModel.Text), new SqlParameter("@plaka", txtPlak.Text), new SqlParameter("@tarih", txtTarih.Text) };
            komut.Parameters.AddWithValue("@marka", txtMark.Text);
            komut.Parameters.AddWithValue("@model", txtModel.Text);
            komut.Parameters.AddWithValue("@no", txtNo.Text);
            komut.Parameters.AddWithValue("@plaka", txtPlak.Text);
            komut.Parameters.AddWithValue("@tarih", txtTarih.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sil = "DELETE FROM arac where no = @no";
            komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string guncelle = "UPDATE arac set marka = @marka, model = @model, plaka = @plaka, tarih=@tarih WHERE no = @no ";
            komut = new SqlCommand(guncelle, baglanti);
            komut.Parameters.AddWithValue("@marka", txtMark.Text);
            komut.Parameters.AddWithValue("@model", txtModel.Text);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
            komut.Parameters.AddWithValue("@plaka", txtPlak.Text);
            komut.Parameters.AddWithValue("@tarih", Convert.ToDateTime(txtTarih.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNo_Click(object sender, EventArgs e)
        {

        }

    }
}
