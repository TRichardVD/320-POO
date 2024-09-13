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

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public void update()
        {
            Random rnd = new Random();

            y += rnd.Next(-1, 2);
            


            if (++x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
        }

        public void draw()
        {
            Console.CursorVisible = false;
            int tempY = y;

            foreach (var item in view)
            {
                Console.SetCursorPosition(x, tempY++);

                Console.Write(item);
            }
            

        }


    }
}
