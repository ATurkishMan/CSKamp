using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCostumer musteri1 = new IndividualCostumer();
            musteri1.Id = 1;
            musteri1.CustomerNo = "1654987";
            musteri1.Name = "Tarık";
            musteri1.Surname = "Yördem";
            musteri1.TcNo = "1223654";

            CorporateCostumer musteri2 = new CorporateCostumer();  
            musteri2.Id = 2;
            musteri2.VergiNo = "4687421";
            musteri2.CustomerNo = "45698732";
            musteri2.SirketAdi = "Kodlama.io";

            Costumer musteri3 = new IndividualCostumer();
            Costumer musteri4 = new CorporateCostumer();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(musteri1); // CosumerManager sadece Costumer türünde obje alabiliyor.
            costumerManager.Add(musteri2); // CorporateCostumer ve IndividualCostumer Costumer türüne bağlı
            costumerManager.Add(musteri3); // olduğu için Costumer türünün gerektiği alana onları da atabiliyoruz.
            costumerManager.Add(musteri4);
        }
    }
}