using Odev5_5_Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_5_Oyun.Interfaces
{
    internal interface IOfferService
    {
        public void MakeOffer(Game game, User user, Offer offer);
    }
}
