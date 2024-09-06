using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace paraClubPlus
{
    internal static class Plane
    {
        private static int X = 0, Y = 0;

        private static List<Para> passegers = new List<Para>();

        private static string[] view =
            {
                @" _                         ",
                @"| \                        ",
                @"|  \       ______          ",
                @"--- \_____/  |_|_\____  |  ",
                @"  \_______ --------- __>-} ",
                @"        \_____|_____/   |  "
            };

        public static void update()
        {
            if (X >= config.SCREEN_WIDTH)
                X = 0;
            else
                ++X;
        }


        public static void draw() 
        { 
            Console.SetCursorPosition(X, Y);
        }

        public static void landing()
        {
            passegers[0].X = X;
            passegers[0].go();
            passegers.RemoveAt(0);
        }

    }
}
