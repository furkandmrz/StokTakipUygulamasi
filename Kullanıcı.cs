using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipUygulaması
{
    public class Kullanıcı //Kullanıcı sınıfı.
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string KullaniciAdi { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; } 
        public string Sifre {  get; set; }

    }
    public static class KullanıcıListesi                
    {
        public static List<Kullanıcı> kullanıcılar=new List<Kullanıcı>();//Kullanıcı listesini tutar.
    }
}
