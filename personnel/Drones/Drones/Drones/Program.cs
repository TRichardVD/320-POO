using System.Net.Security;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone("Joe", 100, 100);

            List<Building> buildings = new List<Building>
            {
                new Factory(350, 350, 200, 99.9, Color.Black),
                new Store(400, 300, 200, new List<string> { "Lundi: 8h-18h","Mardi: 8h-18h","Mercredi: 8h-18h" }, Color.Green)
            };

            fleet.Add(drone);
            fleet.Add(new Drone("hello", 20, 40));
            fleet.Add(new Drone("blue", 40, 10));
            fleet.Add(new Drone("mmmh", 40, 10));
            fleet.Add(new Drone("qqun", 40, 10));

            try
            {   
                Application.Run(new AirSpace(fleet, buildings));
                Console.WriteLine($"Test1 avec {fleet.Count} drones : OK");
                Application.Exit();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Test1 avec {fleet.Count} drones : FAILED");
                Console.WriteLine(e);
            }


            fleet.Add(new Drone("blue", 40, 10));
            fleet.Add(new Drone("blue", 40, 10));
            fleet.Add(new Drone("blue", 40, 10));
            fleet.Add(new Drone("Mirorange", 40, 10));
            fleet.Add(new Drone("Pierre", 40, 10));

            try
            {
                Application.Run(new AirSpace(fleet, buildings));
                Console.WriteLine($"Test2 avec {fleet.Count} drones : OK");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Test2 avec {fleet.Count} drones : FAILED");
                Console.WriteLine(e);
            }

            try
            {
                fleet.Add(new Drone("purple", 40, 10));
                fleet.Add(new Drone("yellow", 40, 10));
                fleet.Add(new Drone("red", 40, 10));
                Application.Run(new AirSpace(fleet, buildings));
                Console.WriteLine($"Test3 avec {fleet.Count} drones : OK");


            }
            catch (Exception e)
            {
                Console.WriteLine($"Test3 avec {fleet.Count} drones : FAILED");
                Console.WriteLine(e);
                
            }

            

        }
    }
}