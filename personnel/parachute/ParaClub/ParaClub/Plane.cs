using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Plane
    {
        public int x;
        public int y;

        const int MAX_Y = Config.SCREEN_HEIGHT/4;

        private string[] view =
        {
            @" _",
            @"| \",
            @"|  \       ______",
            @"--- \_____/  |_|_\____  |",
            @"  \_______ --------- __>-}",
            @"        \_____|_____/   |"
        };

        public void update()
        {
            


            if (++x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
        }

        public void draw()
        {
            Console.CursorVisible = false;
            int tempY = Math.Abs(y);

            foreach (var item in view)
            {
                Console.SetCursorPosition(x, tempY++);

                Console.Write(item);
            }
            

        }


    }
}
