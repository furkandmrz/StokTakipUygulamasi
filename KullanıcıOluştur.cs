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
    public partial class KullanıcıOluştur : Form          //

    {
        public KullanıcıOluştur()
        {
            InitializeComponent();
        }

        private void KayıtOlButon_Click(object sender, EventArgs e) //Kayıt ol butonuna tıklandığında çalışır.
        {
            string adı = txtAdı.Text;
            string soyadı = txtSoyadı.Text;
            string kullanıcıAdı = txtKullanıcıAdı.Text;
            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string şifre = txtSifre.Text;

            if (adı == "" || soyadı == "" || kullanıcıAdı == "" ||
                email == "" || telefon == "" || şifre == "")
            {
                MessageBox.Show("Eksik bilgi bulunmaktadır!");
                return;
            }

           
                using (var con = SQLiteDbConnection.BaglantiGetir())
                {
                    string query = @"
                    INSERT INTO Users 
                    (Ad, Soyad, KullaniciAdi, TelefonNo, Email, Şifre)
                    VALUES 
                    (@ad, @soyad, @kadi, @tel, @mail, @sifre)";

                    using (var cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ad", adı);               //Formdaki textboxlardan alınan bilgileri parametre olarak ekler.
                    cmd.Parameters.AddWithValue("@soyad", soyadı);
                        cmd.Parameters.AddWithValue("@kadi", kullanıcıAdı);
                        cmd.Parameters.AddWithValue("@tel", telefon);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@sifre", şifre);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kullanıcı başarıyla kaydedildi");

                
                txtAdı.Clear();                       //Formdaki tüm textboxları temizler.
            txtSoyadı.Clear();
                txtKullanıcıAdı.Clear();
                txtTelefon.Clear();
                txtEmail.Clear();
                txtSifre.Clear();
            }
           
        }
    }

