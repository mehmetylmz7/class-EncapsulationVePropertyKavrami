using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar3_EncapsulationAndProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ayse";
            ogrenci1.Soyismi = "Yilmaz";
            ogrenci1.OgrenciNo = 17;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("********************");

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Isim = "Andre";
            ogrenci2.Soyismi = "Insesta";
            ogrenci2.OgrenciNo = 8;
            ogrenci2.Sinif = 1;
            ogrenci2.OgrenciBilgileriniGetir();

            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

            Console.WriteLine("********************");

            Ogrenci ogrenci3 = new Ogrenci("Didim","Zagazingo",217,11);
            ogrenci3.OgrenciBilgileriniGetir();




            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string  soyismi;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
       

        public string Soyismi { get => soyismi; set => soyismi = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public int Sinif {
            get => sinif;

            set
            {
                if (value<1)
                {
                    Console.WriteLine("sinif 1 den düsük olamaz..");
                    sinif = 1; 
                }
                else
                sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyismi, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyismi = soyismi;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() {}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*****Ogrenci Bilgileri*****");
            Console.WriteLine("Ogrencinin adi: "+this.isim);
            Console.WriteLine("Ogrencinin Soyismi: "+this.soyismi);
            Console.WriteLine("Ogrencinin Numarasi: "+this.ogrenciNo);
            Console.WriteLine("Ogrencinin Sinifi: "+this.sinif);
        }

        public void  SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

    }

}
