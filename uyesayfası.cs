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
    public partial class uyesayfası : Form
    {
         List<kitap> kitaplarim;
        public uyesayfası(List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            kitap bulkitap = null;
            int b_kitapid =Convert.ToInt32(txt_ara.Text);

            foreach(kitap kitap in kitaplarim)
            {
                if(kitap.getkitapid() == b_kitapid)
                {
                    bulkitap = kitap;
                }
            }
            dataGridView_uye.Rows.Clear();
            dataGridView_uye.Rows.Add(bulkitap.getkitapid(),bulkitap.getkitapisim(),bulkitap.getkitapyazar(),bulkitap.getsayfasayisi(),bulkitap.gettur());
        }

        private void uyesayfası_Load(object sender, EventArgs e)
        {/*
           foreach(kitap kitap in kitaplarim)
            {
                dataGridView_uye.Rows.Add(kitap.getkitapid(),kitap.getkitapisim(),kitap.getkitapyazar(),kitap.getsayfasayisi(),kitap.gettur());
            }
            
        }*/

        private void dataGridView_uye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView_uye.Rows.Remove(dataGridView_uye.CurrentRow);
            foreach(kitap bulkitap in kitaplarim)
            {
                dataGridView_uye.Rows.Add(bulkitap.getkitapid(), bulkitap.getkitapisim(), bulkitap.getkitapyazar(), bulkitap.getsayfasayisi(), bulkitap.gettur());
            }
        }
    }
}
