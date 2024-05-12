using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UpdateKTS
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        void ktsKayıtları()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=KontrolTahrikSistemi;Integrated Security =SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM ktsKayıtları", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView_kayıtlar.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ktsKayıtları();
        }

        private void dataGridView_kayıtlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_testNo.Text = dataGridView_kayıtlar.CurrentRow.Cells[2].Value.ToString();
            textBox_testiGerceklestiren.Text = dataGridView_kayıtlar.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ktsKayıtları(KtsSeriNo, TestNumarasi, TestiGerceklestiren) VALUES(@KtsSeriNo, @TestNumarasi, @TestiGerceklestiren)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TestNumarasi", textBox_testNo.Text);
            komut.Parameters.AddWithValue("@TestiGerceklestiren", textBox_testiGerceklestiren.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ktsKayıtları();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_testNo.Text) && int.TryParse(textBox_testNo.Text, out int testNo))
            {
                string sorgu = "DELETE FROM ktsKayıtları WHERE TestNumarasi = @testNo";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@testNo", testNo);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                ktsKayıtları();
            }
            else
            {
                label_hata.Text = "Lütfen geçerli bir test numarası girin.";
            }
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            if(dataGridView_kayıtlar.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView_kayıtlar.SelectedRows[0].Index;
                int testNo = Convert.ToInt32(dataGridView_kayıtlar.Rows[rowIndex].Cells["TestNumarasi"].Value);

                string sorgu = "UPDATE ktsKayıtları SET KtsSeriNo=@KtsSeriNo, TestNumarasi=@TestNumarasi, TestiGerceklestiren=@TestiGerceklestiren WHERE TestNumarasi=@TestNo";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TestNumarasi", textBox_testNo.Text);
                komut.Parameters.AddWithValue("@TestiGerceklestiren", textBox_testiGerceklestiren.Text);
                komut.Parameters.AddWithValue("@TestNo", testNo);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                ktsKayıtları();
            }
            else
            {
                label_hata.Text = "Güncelleme için bir kayıt seçin.";
            }
        }

        private void button_basla_Click(object sender, EventArgs e)
        {
            
            string testNumarası = textBox_testNo.Text;
            string testiGerceklestiren = textBox_testiGerceklestiren.Text;


            if (string.IsNullOrEmpty(testNumarası) || string.IsNullOrEmpty(testiGerceklestiren))
            {
                label_hata.Text = "Lütfen tüm alanları doldurun.";
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void label_testiGerceklestiren_Click(object sender, EventArgs e)
        {

        }
    }
}
