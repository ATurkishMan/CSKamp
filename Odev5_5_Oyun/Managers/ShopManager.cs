using Odev5_5_Oyun.Entities;
using Odev5_5_Oyun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_5_Oyun.Managers
{
    internal class ShopManager : IShopService
    {
        public void BuyGame(User user, Game game)
        {
            user.BoughtGames.Add(game.Name);
            Console.WriteLine(user.LName + " bought " + game.Name);
        }
    }
}
