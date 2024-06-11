using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5_5_Oyun.Entities;
using Odev5_5_Oyun.ExternelServices;

namespace Odev5_5_Oyun.Managers
{
    internal class UserManager : IUserService
    {
        UserValidationManager _validationManager;
        public UserManager(UserValidationManager validationManager) //construction
        {
            _validationManager = validationManager;
        }
        public void Add(User gamer)
        {
            if (_validationManager.ValidateGamer(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Oyuncu Gerçek Değil!");
            }
        }

        public void Delete(User gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(User gamer)
        {
            Console.WriteLine("Oyuncu Yenilendi");
        }
    }
}
