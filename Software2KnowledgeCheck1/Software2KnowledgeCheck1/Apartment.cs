using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Apartment : Building
    {
        public int NumberOfUnits { get; set; }
        public int NumberOfOpenUnits { get; set; }

        public bool HasParking { get; set; }

        public Apartment() 
        {
            Random rnd = new Random();
            int numberOfUnits = rnd.Next(1, 100);
            int numberOfLeasedUnits = rnd.Next(1, numberOfUnits);
            int numberOfOpenUnits = numberOfUnits - numberOfLeasedUnits;
            int hasParkingInt = rnd.Next(1, 10) - 1;
            bool hasParking = Convert.ToBoolean(hasParkingInt);
            NumberOfUnits = numberOfUnits;
            NumberOfOpenUnits = numberOfOpenUnits;
            HasParking = hasParking;

        }
        public Apartment(int numberOfUnits, int numberOfOpenUnits, bool hasParking)
        {
            NumberOfUnits = numberOfUnits;
            NumberOfOpenUnits = numberOfOpenUnits;
            HasParking = hasParking;
        }
    }
}
