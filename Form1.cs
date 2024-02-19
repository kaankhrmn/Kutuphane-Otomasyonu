using kütüphane_otomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyonu
{
    public partial class Form1 : Form
    {

        List<kisi> kisilerim = new List<kisi>();
        List<kitap>kitaplarim = new List<kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanıcıadi.Text = string.Empty;
            txt_şifre.Text = string.Empty;
        }

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullanıcıadi.Text;
            sifre = txt_şifre.Text;
            bool kontrol = false;
            foreach (kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getsifre() && kisi.yetki == "admin")
                {
                    adminsayfası adminsayfası = new adminsayfası(kisilerim,kitaplarim);
                    adminsayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getsifre() && kisi.yetki == "uye")
                {
                    uyesayfası uyesayfası = new uyesayfası(kitaplarim);
                    uyesayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            { MessageBox.Show("KULLANICI BULUNAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1, "kaan", "kahraman", DateTime.Now, "kaan", "11", "admin"));
            kisilerim.Add(new kisi(2, "ayşe", "kahraman", DateTime.Now, "ayşe", "11", "uye"));
            kisilerim.Add(new kisi(3, "nurgül", "kahraman", DateTime.Now, "nurgül", "11", "uye"));
            kisilerim.Add(new kisi(4, "selvet", "kahraman", DateTime.Now, "selvet", "11", "uye"));

            kitaplarim.Add(new kitap(1, "arabalar", "halide edip", "türkçe", "oskar", "hikaye", 10, 230, 2000));
            kitaplarim.Add(new kitap(2, "evler", "yaşar sami", "türkçe", "oskar", "hikaye", 12, 350, 2001));
            kitaplarim.Add(new kitap(3, "okullar", "kerem bal", "türkçe", "oskar", "hikaye", 14, 120, 2002));
            kitaplarim.Add(new kitap(4, "köyler", "icardi simge", "türkçe", "oskar", "hikaye", 20, 213, 2003));

        }
    }
}
