using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace snailExBase
{
    internal class snail
    {
        public static List<snail> snails = new List<snail>();
        public snail(int posY)
        {
            Y = posY;
            snails.Add(this);
        }

        public int plife = 50;
        
        public int X = 0;
        public int Y = 0;


        public string alive = "_@_ö";
        public string dead = "____";

        public void move()
        {

            Console.CursorVisible = false;
            Console.SetCursorPosition(++X, Y);
            Console.Write(alive);
            plife--;

        }

        public void die() {
            Console.SetCursorPosition(X, Y);
            Console.Write(dead);
        
        }

        
    }
}
