using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    class Substitution
    {
        public int PlayerIn { get; set; }
        public int PlayerOut { get; set; }
        private int Minute { get; set; }
        public int PlayerInMinutes {
            get
            {
                return 91-Minute;
            } 
        }
        public int PlayerOutMinutes {
            get
            {
                return 91-Minute;
            }
        }
        public Substitution(int playerin, int playerout, int minute)
        {
            PlayerIn = playerin;
            PlayerOut = playerout;
            Minute = minute;
        }
    }
}
