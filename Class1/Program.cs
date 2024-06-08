using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Tarık Yördem";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Rüveyda Yördem";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "Bilgen Şahin";
            kurs3.IzlenmeOrani = 100;

            Kurs[] Kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursunEgitmeni);
                Console.WriteLine(kurs.IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}