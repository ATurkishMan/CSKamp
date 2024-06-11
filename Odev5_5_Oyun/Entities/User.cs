using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_5_Oyun.Entities
{
    internal class User
    {
        public long TcId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int BirthYear { get; set; }
        public List<string> BoughtGames { get; set; }
    }
}
