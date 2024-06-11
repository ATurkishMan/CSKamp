using Odev5_5_Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_5_Oyun.Interfaces
{
    internal interface IShopService
    {
        public void BuyGame(User user, Game game);

    }
}
