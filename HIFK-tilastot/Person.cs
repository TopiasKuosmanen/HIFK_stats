using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIFK_tilastot
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public int YearOfAccession { get; set; }
        public DateTime ContractEndDate { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName}, Ikä: {Age}, ID: {Id}";
            }
        }

        public string PlayerInfo
        {
            get
            {
                return $"#{Number} {LastName} {FirstName}";
            }
        }
        public string PlayerInfo2
        {
            get
            {
                return $"{LastName} {FirstName} {Id}";
            }
        }

        public string EditPlayerInfo
        {
            get
            {
                if (FirstName is null)
                {
                    return $"{LastName}";
                }
                else
                {
                    return $"{LastName} {FirstName}";
                }
            }
        }
    }

}
