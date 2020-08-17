using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class Game
    {
        public int Id { get; set; }
        public string Opponent { get; set; }
        public DateTime DateTime { get; set; }
        public string Serie { get; set; }
        public string Result { get; set; }
        public int ResultCode { get; set; }
        public string Stadion { get; set; }
        public Boolean Home_match { get; set; }
        public Boolean Extra_time { get; set; }
        public Boolean Penalties { get; set; }


        public string HomeMatchInfo
        {
            get
            {
                if (Home_match == true)
                {
                    return $"Home";
                }
                else
                {
                    return $"Away";
                }
            }

        }
        public string FullInfo
        {
            get
            {
                if (Home_match == true)
                {
                    return $"{Serie} {DateTime.ToString("dd.MM.yyyy HH:mm")} HIFK - {Opponent} {Result}     {Stadion}";
                }
                else
                {
                    return $"{Serie} {DateTime.ToString("dd.MM.yyyy HH:mm")} {Opponent} - HIFK {Result}     {Stadion}";
                }
            }
        }

        public string Fixture
        {
            get
            {
                if (Home_match == true)
                {
                    return $"{DateTime.ToString("dd.MM.yyyy HH:mm")}  {Serie}   HIFK - {Opponent}     {Stadion}";
                }
                else
                {
                    return $"{DateTime.ToString("dd.MM.yyyy HH:mm")}  {Serie}   {Opponent} - HIFK     {Stadion}";
                }
            }
        }

        public string SmallFixture
        {
            get
            {
                if (Home_match == true)
                {
                    return $"{DateTime.ToString("dd.MM.yyyy")} HIFK - {Opponent}";
                }
                else
                {
                    return $"{DateTime.ToString("dd.MM.yyyy")} {Opponent} - HIFK";
                }
            }
        }

        public string SmallFixtureWithoutTheDate
        {
            get
            {
                if (Home_match == true)
                {
                    return $"HIFK - {Opponent}";
                }
                else
                {
                    return $"{Opponent} - HIFK";
                }
            }
        }

    }
}
