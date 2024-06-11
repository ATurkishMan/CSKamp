using Odev5_5_Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_5_Oyun.Managers
{
    internal class OfferManager
    {
        public void MakeOffer(Game game, User user, Offer offer)
        {
            if (user.BoughtGames.Contains(game.Name) == false)
            {
                Console.WriteLine("Tebrikler! " + game.Name + " oyunundan %" + 
                    offer.DiscountRate*100 + " indirim kazandınız!");
            }
            else
            {
                Console.WriteLine("Üzgünüm... Şimdilik indirim yok.");
            }
            
        }
    }
}
