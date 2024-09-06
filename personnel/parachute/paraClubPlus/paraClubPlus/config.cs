using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paraClubPlus
{
    static internal class config
    {
        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;


        public static void update()
        {
            Console.SetWindowSize(SCREEN_WIDTH, SCREEN_HEIGHT);
        }

    }
}
