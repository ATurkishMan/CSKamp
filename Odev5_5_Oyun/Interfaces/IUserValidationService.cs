using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5_5_Oyun.Entities;

namespace Odev5_5_Oyun.ExternelServices
{
    internal interface IUserValidationService
    {
        bool ValidateGamer(User gamer);
    }
}
