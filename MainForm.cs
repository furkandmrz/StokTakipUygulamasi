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
    public partial class MainForm : Form     // Ana form sınıfı
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)   // Ürün ekleme butonuna tıklama olayı
        {
            ÜrünEkle ekle = new ÜrünEkle();
            ekle.Show();

        }

        public void ürünListeleme_Click(object sender, EventArgs e)    // Ürün listeleme butonuna tıklama olayı
        {
            ÜrünListele liste = new ÜrünListele();
            liste.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
