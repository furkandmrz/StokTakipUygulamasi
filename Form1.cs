
using MarketStokTakip.Database;
using Microsoft.Data.Sqlite;
using StokTakipUygulaması.Helpers;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace StokTakipUygulaması { 
    
    public partial class Form1 : Form                //Bu kısım giriş ekranını oluşturur ve kullanıcı doğrulamasını yapar.
    {
        void SktKontrolEt()                                    //Son kullanma tarihi yaklaşan ürünleri kontrol eder ve Telegram'a uyarı mesajı gönderir.
        {
            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string sql = @"
        SELECT UrunAdi, Skt 
        FROM Products
        WHERE date(Skt) <= date('now','+3 day')";

                SqliteCommand cmd = new SqliteCommand(sql, con);
                SqliteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string urun = dr["UrunAdi"].ToString();
                    string skt = dr["Skt"].ToString();

                    string mesaj =
                        $"⚠️ SKT UYARISI\n" +
                        $"Ürün: {urun}\n" +
                        $"Tarih: {skt}";

                    TelegramHelper.MesajGonder(mesaj);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Giriş butonuna tıklandığında çalışır.
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");//Eksik bilgi girilirse uyarı verir.
                return;
            }

            string sql = "SELECT COUNT(*) FROM Users WHERE KullaniciAdi=@u AND Şifre=@p";

            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                var cmd = new SqliteCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", kullaniciAdi);
                cmd.Parameters.AddWithValue("@p", sifre);

                int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

                if (sonuc > 0)
                {
                    MessageBox.Show("Giriş başarılı!");

                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı !!");//Hatalı bilgi girilirse uyarı verir.
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            SktKontrolEt();                 //Son kullanma tarihi yaklaşan ürünleri kontrol eder.


            using (var con = SQLiteDbConnection.BaglantiGetir())    //Veritabanında kullanıcı tablosu yoksa oluşturur.
            {
                string sql = @"
        CREATE TABLE IF NOT EXISTS Users (
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    Ad TEXT,
    Soyad TEXT,
    KullaniciAdi TEXT NOT NULL UNIQUE,
    TelefonNo TEXT,
    Email TEXT,
    Şifre TEXT NOT NULL
);";                                 //Veritabanında ürün tablosu yoksa oluşturur.
                string sqlProducts = @"
        CREATE TABLE IF NOT EXISTS Products (
           
            Barkod TEXT NOT NULL UNIQUE,
            UrunAdi TEXT NOT NULL,
            Marka TEXT,
            Skt TEXT,
            Fiyat INTEGER NOT NULL,
            Adet INTEGER NOT NULL
        );";

                new SqliteCommand(sqlProducts, con).ExecuteNonQuery();

                SqliteCommand cmd = new SqliteCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            using (var con = SQLiteDbConnection.BaglantiGetir())
            {
                string sql = "INSERT OR IGNORE INTO Users (KullaniciAdi, Şifre) VALUES ('admin','1234')"; //Varsayılan admin kullanıcısı oluşturur.
                SqliteCommand cmd = new SqliteCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıOluştur yeniKullanıcı = new KullanıcıOluştur();
            yeniKullanıcı.Show();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
