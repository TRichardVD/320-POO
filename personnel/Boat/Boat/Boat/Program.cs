using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Boat CurrentBoat = new Boat("Suisse", 10, 2000);
            List<Boat> boats = new List<Boat>();
            boats.Add(CurrentBoat);

            while (true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("Création d'un nouveau bateau");


                        CurrentBoat = new Boat(Demander("\n\tCountry :"), Convert.ToInt32(Demander("\n\tTonnage :")), Convert.ToInt32(Demander("\n\tYear :")));
                        boats.Add(CurrentBoat);
                        break;

                    case ConsoleKey.A:
                        Console.WriteLine("\n Ajout d'un container de type : ");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.F:
                                Console.WriteLine("Ajout d'un container de type fridge au bateau");
                                CurrentBoat.Load(new Fridge(Convert.ToInt32(Demander("\n\tWeight :")), Convert.ToInt32(Demander("\n\tTemp :"))));
                                break;

                            case ConsoleKey.R: Console.WriteLine("Ajout d'un container de type radioactif au bateau");
                                CurrentBoat.Load(new Radioactiv(Convert.ToInt32(Demander("\n\tWeight :")), Convert.ToInt32(Demander("\n\tMaxMound :"))));

                                break;

                            default: 
                                Console.WriteLine("Ajout d'un container normal");
                                CurrentBoat.Load(new Container(Convert.ToInt32(Demander("\n\tWeight :"))));

                                break;
                        }
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("Enlver un container du bateau");
                        CurrentBoat.Unload(CurrentBoat.Containers[new Random().Next(0, CurrentBoat.Containers.Count - 1)]);
                        break;

                    case ConsoleKey.Delete:
                        boats.Clear();
                        CurrentBoat = new Boat("France", 10, 2000);
                        boats.Add(CurrentBoat);
                        break;


                    default:

                        foreach (Boat b in boats)
                        {
                            if (b == CurrentBoat)
                                Console.WriteLine($"(CURRENTBOAT)  Country : {b.Country}, Tonnage :  {b.Tonnage}, Year : {b.Year}, NbrContainer : {b.Containers.Count}");
                            else
                                Console.WriteLine($"Country : {b.Country}, Tonnage :  {b.Tonnage}, Year : {b.Year}, NbrContainer : {b.Containers.Count}");
                        }
                        break;

                }

            }
        }

        public static string Demander(string Question)
        {
            Console.Write(Question);
            return Console.ReadLine();
        }
    }
}



