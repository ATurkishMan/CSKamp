
using System;
using Metotlar;

namespace ders3
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + ": " + urun.Aciklama);
            }
            Console.WriteLine("-------------Metotlar-------------");

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
        }
    }
}