using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_kulüp_üyeleri_bilgileri
{
    internal class Kulüp_üyeleri_bilgileri
    {
        string ad;
        string soyad;
        string bolum;
        string sinif;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string BOLUM
        {
            get { return bolum; }
            set { bolum = value.ToUpper(); }
        }

        public string SINIF
        {
            get { return sinif; }
            set { sinif = value.ToUpper(); }
        }

        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kulüp_üyeleri_bilgileri()
        {
            ad = " ";
           soyad = " ";
           bolum = " ";
           sinif = " ";
           cinsiyet = ' ';
        }
    }
}
