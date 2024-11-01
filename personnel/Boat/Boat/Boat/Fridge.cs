using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Fridge : Container
    {
        public int Temperature { get; private set; } = 0;

        public Fridge(int weight, int temp) : base(temp)
        {
            Temperature = temp;
        }
    }
}
