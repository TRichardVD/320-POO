using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace paraClubPlus
{
    internal class Para
    {

        public static List<string> names = new List<string>()
        {
            "Alice","Lucas","Emma","Léo","Chloé","Gabriel","Lina","Louis","Jade","Hugo",
            "Louise","Arthur","Mila","Raphaël","Zoé","Jules","Manon","Nathan","Léa","Tom",
            "Inès","Adam","Sarah","Paul","Anna","Noah","Camille","Ethan","Eva","Maël",
            "Léna","Mathis","Rose","Liam","Clara","Enzo","Juliette","Théo","Ambre","Aaron",
            "Lou","Victor","Nina","Isaac","Maya","Sacha","Alicia","Robin","Lola","Maxime",
            "Alice","Oscar","Iris","Simon","Élise","Antoine","Mia","Rayan","Sofia","Gaspard",
            "Louna","Alexandre","Élina","Bastien","Lily","Matteo","Ava","Martin","Livia",
            "Noé","Léonie","Kylian","Aline","Timéo","Margaux","Clément","Maëlys","Nolan",
            "Émilie","Romain","Soline","Samuel","Amandine","Benjamin","Anaïs","Eliott",
            "Lucie","Axel","Océane","Mathéo","Célia","Quentin","Aurore","Loris","Jeanne",
            "Thibault","Flora", "Blud"

        };

        public int X = 0;
        public int Y = 0;

        internal string name = "";

        internal static List<Para> ActivPara = new List<Para>();

        private string[] withoutParachute =
         {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
        };

        private string[] withParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        public static void update()
        {
            foreach (Para p in ActivPara)
            {
                if (p.Y++ == config.SCREEN_HEIGHT)
                {

                }
                else if (p.Y++ >= config.SCREEN_HEIGHT / 2)
                {

                }
                else
                {
                    ActivPara.Remove(p);

                }
            }

        }

        public static void draw()
        {



        }

        public void go()
        {
            ActivPara.Add(this);
        }

        public void stop()
        {
            ActivPara.Remove(this);
        }

        public Para(string Name)
        {
            name = Name;

        }

        public Para()
        {
            Random rnd = new Random();
            names[rnd.Next()] = name;

        }

    }
}
