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
    public partial class adminsayfası : Form
    {
        List<kisi> kisilerim;
        List<kitap> kitaplarim;

        public adminsayfası(List<kisi> kisilerim, List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(1, "tunahan", "kahraman", DateTime.Now, "tuna", "11", "uye");
            foreach (kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(), kisi.getisim(), kisi.getsoyisim(), kisi.getolusturmaTarih(), kisi.getkullaniciadi(), kisi.getsifre(), kisi.getyetki());
            }
            foreach (kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            DateTime olusturmatarihi = DateTime.Now;
            string kullniciadi = txt_kullanıcıadı.Text;
            string sifre = txt_şifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Add(id, isim, soyisim, olusturmatarihi, kullniciadi, sifre, yetki);




        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_olusturmatarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullanıcıadı.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_şifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            DateTime olusturmatarihi = DateTime.Now;
            string kullniciadi = txt_kullanıcıadı.Text;
            string sifre = txt_şifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Add(id, isim, soyisim, olusturmatarihi, kullniciadi, sifre, yetki);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_isim.Text = string.Empty;
            txt_soyisim.Text = string.Empty;
            txt_olusturmatarihi.Text = string.Empty;
            txt_kullanıcıadı.Text = string.Empty;
            txt_şifre.Text = string.Empty;
            txt_yetki.Text = string.Empty;

        }

        private void btn_ekleK_Click(object sender, EventArgs e)
        {
            int idK = Convert.ToInt32(txt_idK.Text);
            string isimK = txt_isimK.Text;
            string yazarK = txt_yazarK.Text;
            string diliK = txt_diliK.Text;
            string yayıneviK = txt_yayıneviK.Text;
            string turK = txt_turK.Text;
            int adetK = Convert.ToInt32(txt_adetK.Text);
            int sayfasayısıK = Convert.ToInt32(txt_sayfasayısıK.Text);
            int basımyılıK = Convert.ToInt32(txt_basımyılıK.Text);

            dataGridView2.Rows.Add(idK, isimK, yazarK, diliK, yayıneviK, turK, adetK, sayfasayısıK, basımyılıK);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idK.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_isimK.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_yazarK.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_diliK.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayıneviK.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_turK.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adetK.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfasayısıK.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basımyılıK.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_silK_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_güncelleK_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            int idK = Convert.ToInt32(txt_idK.Text);
            string isimK = txt_isimK.Text;
            string yazarK = txt_yazarK.Text;
            string diliK = txt_diliK.Text;
            string yayıneviK = txt_yayıneviK.Text;
            string turK = txt_turK.Text;
            int adetK = Convert.ToInt32(txt_adetK.Text);
            int sayfasayısıK = Convert.ToInt32(txt_sayfasayısıK.Text);
            int basımyılıK = Convert.ToInt32(txt_basımyılıK.Text);

            dataGridView2.Rows.Add(idK, isimK, yazarK, diliK, yayıneviK, turK, adetK, sayfasayısıK, basımyılıK);
        }

        private void btn_temizleK_Click(object sender, EventArgs e)
        {
            txt_idK.Text = string.Empty;
            txt_isimK.Text = string.Empty;
            txt_yazarK.Text = string.Empty;
            txt_diliK.Text = string.Empty;
            txt_yayıneviK.Text = string.Empty;
            txt_turK.Text = string.Empty;
            txt_adetK.Text = string.Empty;
            txt_sayfasayısıK.Text = string.Empty;
            txt_basımyılıK.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisi hedefkisi = null;
            int secilenkisiid = Convert.ToInt32(txt_araüye.Text);

            foreach(kisi kisi in kisilerim)
            {
                if(kisi.getid()==secilenkisiid)
                { hedefkisi=kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getid(),hedefkisi.getisim(),hedefkisi.getsoyisim(),hedefkisi.getolusturmaTarih(),hedefkisi.getkullaniciadi(),hedefkisi.getsifre(),hedefkisi.getyetki());
        }

        private void btn_uyeyenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach(kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(),kisi.getisim(),kisi.getsoyisim(),kisi.getolusturmaTarih(),kisi.getkullaniciadi(),kisi.getsifre(),kisi.getyetki());
            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            kitap hedefkitap = null;

            int secilenkitapid = Convert.ToInt32(txt_arakitap.Text);
            foreach (kitap kitap in kitaplarim)
            {
                if(kitap.getkitapid() == secilenkitapid)
                {
                    hedefkitap = kitap; 
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimyili());
        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach(kitap hedefkitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimyili());

            }

        }

        private void ÇIKIŞ_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
        }
    }
}
