using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class PlayerNationality
    {
        List<PlayerNationality> nationalities = new List<PlayerNationality>();

        public int NationalityId { get; set; }
        public string Nationality { get; set; }


        public string ReturnNationalities
        {
            get
            {
                return $"{Nationality}";
            }
        }
    }
}
