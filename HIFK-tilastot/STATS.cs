using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class STATS
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string League { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int PlayedMinutes { get; set; }
        public int StartingXI { get; set; }
        public int SubstitutedIn { get; set; }
        public int OnTheBench { get; set; }
        public int Games { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName}, Maalit: {Goals}, Syötöt: {Assists}, P: {Games}";
            }

        }

        public string TopScore
        {
            get
            {
                return $"{FirstName} {LastName}, Goals: {Goals}";
            }
        }

    }
}
