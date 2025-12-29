using MarketStokTakip.Database;


using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StokTakipUygulaması
{
    public partial class ÜrünListele : Form
    {
        void UrunleriYenile()
        {
            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string sql = "SELECT * FROM Products";

                SqliteCommand cmd = new SqliteCommand(sql, con);
                SqliteDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                urunListesi.DataSource = dt;
            }
        }

        public ÜrünListele()
        {
            InitializeComponent();
        }
        void UrunleriGetir()             // Ürünleri veritabanından çekip DataGridView'e yükleyen metot
        {
            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string query = "SELECT * FROM Products";
                using (var cmd = new SqliteCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        urunListesi.DataSource = dt;
                    }
                }
            }
        }

        private void ÜrünListele_Load(object sender, EventArgs e) // Form yüklendiğinde ürünleri getirir
        {
            UrunleriGetir();


            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string query = "SELECT * FROM Products";
                using (var cmd = new SqliteCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        urunListesi.DataSource = dt;
                    }
                }
            }
        }

        private void urunListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)     // Ürünü silme butonu
        {
            if (urunListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin");
                return;
            }



            string barkod = urunListesi.SelectedRows[0].Cells["Barkod"].Value.ToString();

            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string query = "DELETE FROM Products WHERE Barkod = @barkod";
                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@barkod", barkod);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Ürün silindi");

            UrunleriGetir();
        }

        private void StokEksilt_Click(object sender, EventArgs e)  // Stok eksiltme butonu
        {
            if (urunListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen stoktan eksiltilecek ürünü seçin");
                return;
            }
            {
                string barkod = urunListesi.SelectedRows[0].Cells["Barkod"].Value.ToString();
                int adet = Convert.ToInt32(urunListesi.SelectedRows[0].Cells["Adet"].Value);

                if (adet <= 0)
                {
                    MessageBox.Show("Stokta ürün kalmadı");
                    barkod = urunListesi.SelectedRows[0].Cells["Barkod"].Value.ToString();

                    using (var con = SQLiteDbConnection.BaglantiGetir())
                    {
                        string query = "DELETE FROM Products WHERE Barkod = @barkod";
                        using (var cmd = new SqliteCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@barkod", barkod);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    UrunleriGetir();
                    return;
                }

                using (var con = SQLiteDbConnection.BaglantiGetir())                // Veritabanında ürünün adetini 1 azaltır
                {
                    string query = "UPDATE Products SET Adet = Adet - 1 WHERE Barkod = @barkod";
                    using (var cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@barkod", barkod);
                        cmd.ExecuteNonQuery();
                    }
                }
                UrunleriGetir();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (urunListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen ürün seçin");
                return;
            }

            string barkod = urunListesi.SelectedRows[0].Cells["Barkod"].Value.ToString();

            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string sql = @"
        UPDATE Products
        SET Adet = Adet + 1
        WHERE Barkod = @b ";

                SqliteCommand cmd = new SqliteCommand(sql, con);
                cmd.Parameters.AddWithValue("@b", barkod);
                

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Stok artırıldı");
            UrunleriYenile();

        }
    }
}
