using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snailExBase
{
    internal class Program
    {

        static void Main(string[] args)
        {
            snail toto = new snail(10);
            snail titi = new snail(14);

            for (; toto.plife > 0; toto.plife--)
            {
                Console.Clear();
                Console.CursorVisible = false;
                toto.move() ; titi.move() ;
                Thread.Sleep(40);

            }

            toto.die();
            titi.die();

            Console.Read();

        }
    }
}
