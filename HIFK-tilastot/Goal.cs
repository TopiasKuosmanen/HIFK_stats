using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class GOAL
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Score { get; set; }
        public bool Winner { get; set; }
        public int Player { get; set; }
        public int Assist { get; set; }
        public bool Penalty { get; set; }
        public int Minute { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssistFirstName { get; set; }
        public string AssistLastName { get; set; }
    }
}
