using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5_5_Oyun.Entities;

namespace Odev5_5_Oyun.ExternelServices
{
    internal interface IUserService
    {
        void Add(User gamer);
        void Delete(User gamer);
        void Update(User gamer);
    }
}
