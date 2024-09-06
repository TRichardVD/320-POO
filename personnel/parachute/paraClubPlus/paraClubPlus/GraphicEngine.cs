using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paraClubPlus
{
    internal static class GraphicEngine
    {
        public static int tickDuration = 100;


        public class obj
        {
            public int priority;

            public static List<int> priList = new List<int>();

            public char[,] content;

            public obj(int pri) { 
                foreach (int p in priList)
                {
                    if (p == pri)
                        Environment.Exit(1);
                }

                priList.Add(this.priority = pri);
            }


        }

        public static int floorCount = 0;





    }
}
