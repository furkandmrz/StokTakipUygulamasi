using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipUygulaması
{
    public class ürün        //ürün classı ürün bilgilerini tutmak için oluşturuldu
    {
        public string UrunAdi { get; set; }
        public string Marka { get; set; }
        public DateTime Skt { get; set; }
        public string Barkod { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }
    public static class UrunStok
    {
        public static List<ürün> Urunler = new List<ürün>();
    }
}
