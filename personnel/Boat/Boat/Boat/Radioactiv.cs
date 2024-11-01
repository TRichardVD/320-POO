using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Radioactiv : Container
    {
        public int MaxMound = 0;

        public Radioactiv(int weight, int maxMound) : base(weight)
        {
            MaxMound = maxMound;
        }

    }
}
