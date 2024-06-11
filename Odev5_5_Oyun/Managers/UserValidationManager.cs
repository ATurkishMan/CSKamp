using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5_5_Oyun.Entities;
using Odev5_5_Oyun.ExternelServices;

namespace Odev5_5_Oyun.Managers
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool ValidateGamer(User gamer)
        {
            if (gamer.FName == "TARIK" && gamer.LName == "YORDEM" &&
                gamer.TcId == 12345678910 && gamer.BirthYear == 2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
