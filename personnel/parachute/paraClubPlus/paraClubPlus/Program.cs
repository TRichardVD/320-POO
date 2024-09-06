using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paraClubPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey(true);

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Spacebar:
                        Plane.landing();
                        break;


                    default:
                        break;
                }
            }
            Console.Clear();

            Para.update();
            Plane.update();

            Para.draw();
            Plane.draw();



            




        }
    }
}
