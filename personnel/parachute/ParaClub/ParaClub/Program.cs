using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Para Bob = new Para();
            Plane avion1 = new Plane();


            Config.update();

            while (true)
            {
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            
                        break;
                            
                    }
                }

                // Modifier le modèle (ce qui *est*)
                avion1.update();
                

                // Modifier ce que l'on *voit*
                Console.Clear();
                avion1.draw();


                // Temporiser
                Thread.Sleep(30);
            }



        }
    }
}
