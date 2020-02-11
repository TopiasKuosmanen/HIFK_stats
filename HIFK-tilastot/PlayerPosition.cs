using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class PlayerPosition
    {
        List<PlayerPosition> positions = new List<PlayerPosition>();

        public int PositionId { get; set; }
        public string Position { get; set; }

        public string ReturnPositions
        {
            get
            {
                return $"{Position}";
            }
        }
    }
}
