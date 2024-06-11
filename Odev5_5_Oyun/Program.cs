using Odev5_5_Oyun.Entities;
using Odev5_5_Oyun.Managers;
using System;

namespace Odev5_5_Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.FName = "TARIK";
            user1.LName = "YORDEM";
            user1.TcId = 12345678910;
            user1.BirthYear = 2001;
            user1.BoughtGames = [];

            Game game1 = new Game();
            game1.Name = "Survive";
            game1.Price = 100;
            Game game2 = new Game();
            game2.Name = "MakeDown";
            game2.Price = 200;

            ShopManager shopManager = new ShopManager();
            shopManager.BuyGame(user1, game1);

            Offer offer = new Offer();
            offer.DiscountRate = 0.5;

            OfferManager offerManager = new OfferManager();
            offerManager.MakeOffer(game2, user1, offer);
        }
    }
}