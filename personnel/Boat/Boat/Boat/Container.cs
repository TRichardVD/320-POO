using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Container
    {
        public readonly int Id;
        public int Weight { get; private set; } = default(int);

        private int NbrContainer = 0;

        public Container(int weight)
        {
            this.Weight = weight;
            Id = NbrContainer++;
        }

    }
}
