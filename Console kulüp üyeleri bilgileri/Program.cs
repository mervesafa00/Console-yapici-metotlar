using System.Security.Cryptography.X509Certificates;

namespace Console_kulüp_üyeleri_bilgileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kulüp_üyeleri_bilgileri uye = new Kulüp_üyeleri_bilgileri();
            uye.AD = "Ada";
            uye.SOYAD = "Sevinç";
            uye.BOLUM = "Bilgisayar Mühendisliği";
            uye.SINIF = "2";
            uye.CINSIYET = 'K';
            Console.WriteLine("Adı: " + uye.AD);
            Console.WriteLine("Soyadı: " + uye.SOYAD);
            Console.WriteLine("Bölümü: " + uye.BOLUM);
            Console.WriteLine("Sınıfı: " + uye.SINIF);
        }
    }
}
