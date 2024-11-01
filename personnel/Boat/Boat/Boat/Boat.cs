using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Boat
    {
        public int Year { get; private set; } = default;
        public int Tonnage { get; private set; } = default;
        public int Weight { get; private set; } = 0;
        public string Country { get; private set; } = "Exemple";
        public List<Container> Containers { get; private set; } = new List<Container>();

        public Boat(string country, int tonnage, int year)
        {
            Country = country;
            Tonnage = tonnage;
            Year = year;
        }

        public bool Load(Container c)
        {
            if (Weight + c.Weight <= Tonnage)
            {
                Weight += c.Weight;
                Containers.Add(c);
                return true;
            }
            else
                return false;
        }

        public bool Unload(Container c)
        {
            if (!Containers.Contains(c))
            {
                Weight -= c.Weight;
                Containers.Remove(c);
                return true;
            }
            else
                return false;
        }

    }
}
