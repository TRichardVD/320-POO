﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal static class Config
    {

        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;
        
        public static void update()
        {
            Console.WindowWidth = SCREEN_WIDTH;
            Console.WindowHeight = SCREEN_HEIGHT;
        }
}
}
