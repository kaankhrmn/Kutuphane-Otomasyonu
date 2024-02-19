using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane_otomasyonu.model
{
    public class kisi
    {

        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime oluşturmaTarih { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }





        public kisi(int id,string isim,string soyisim,DateTime olusturmaTarih,string kullaniciadi,string sifre,string yetki) 
        { 
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.oluşturmaTarih = olusturmaTarih;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public kisi()
        {
            
        }

        public void setid(int id)
        { this.id = id; }
        public int getid()
        { return this.id; }

        public void setisim(string isim)
        { this.isim = isim; }
        public string getisim()
        { return this.isim; }

        public void setsoyisim(string soyisim)
        { this.soyisim = soyisim; }
        public string getsoyisim()
        { return this.soyisim; }

        public void setolusturmaTarih(DateTime setolusturmaTarih)
        { this.oluşturmaTarih = setolusturmaTarih; }
        public DateTime getolusturmaTarih()
        { return this.oluşturmaTarih; }

        public void setkullaniciadi(string kullaniciadi)
        { this.kullaniciadi = kullaniciadi; }
        public string getkullaniciadi()
        { return this.kullaniciadi; }

        public void setsifre(string sifre)
        { this.sifre = sifre; }
        public string getsifre()
        { return this.sifre; }

        public void setyetki(string yetki)
        { this.yetki = yetki; }
        public string getyetki()
        { return this.yetki; }

    
        




    }
}
