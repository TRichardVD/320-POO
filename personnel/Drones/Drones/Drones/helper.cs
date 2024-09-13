using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    internal class helper
    {

        private static Random rdmValue = new Random();
        public static int rdm(int min, int max) => rdmValue.Next(min, max);


    }
}
