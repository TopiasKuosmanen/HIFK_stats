using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class OpponentGoal
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Goal { get; set; }
        public bool Winner { get; set; }
        public bool Penalty { get; set; }
        public int Minute { get; set; }
    }
}
