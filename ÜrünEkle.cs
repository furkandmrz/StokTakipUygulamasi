using MarketStokTakip.Database;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUygulaması
{
    public partial class ÜrünEkle : Form   // ÜrünEkle sınıfı, Form sınıfından türetiliyor
    {
        public ÜrünEkle()
        {
            InitializeComponent();

        }
        public void Ekle_Click(object sender, EventArgs e)       // Ekle butonuna tıklandığında çalışacak metod
        {
            string urunAdi = txtName.Text;                     
            string marka = txtMarka.Text;
            string barkod = txtBarkod.Text;
            DateTime skt = txtSkt.Value;
            int fiyat = (int)txtFiyat.Value;
            int adet = (int)txtAdet.Value;
            if (txtName.Text == "" || txtMarka.Text == "" || txtBarkod.Text == "" || txtFiyat.Value == 0 || txtAdet.Value == 0 || txtSkt.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Eksik veya hatalı bilgi bulunmaktadır!");
            }
            else
            {
                MessageBox.Show("Ürün ekleme işlemi başarılı!");


                string sql = @"
    INSERT INTO Products (Barkod, UrunAdi, Marka, Skt, Fiyat, Adet)
    VALUES (@barkod, @urunAdi, @marka, @skt, @fiyat, @adet);";


                using (var con = SQLiteDbConnection.BaglantiGetir())                 // Veritabanı bağlantısı açılıyor
                {
                    var cmd = new SqliteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@barkod", barkod);
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmd.Parameters.AddWithValue("@marka", marka);
                    cmd.Parameters.AddWithValue("@skt", skt);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@adet", adet);

                    cmd.ExecuteNonQuery();

                    txtName.Clear();               // TextBox'lar temizleniyor
                    txtMarka.Clear();
                    txtBarkod.Clear();
                    txtFiyat.Value = 0;
                    txtAdet.Value = 0;
                }

            }
        }
    }
}
                
    
        
    
