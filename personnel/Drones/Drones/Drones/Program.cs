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
            Drone drone = new Drone(100, 100, "Joe");

            List<Building> buildings = new List<Building>
            {
                new Factory(350, 350, 200, 99.9, Color.Black),
                new Store(400, 300, 200, new List<string> { "Lundi: 8h-18h","Mardi: 8h-18h","Mercredi: 8h-18h" }, Color.Green)
            };

            fleet.Add(drone);
            fleet.Add(new Drone(20, 40, "hello"));
            fleet.Add(new Drone(40, 10, "blue"));
            fleet.Add(new Drone(40, 10, "mmmh"));
            fleet.Add(new Drone(40, 10, "qqun"));

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


            fleet.Add(new Drone(40, 10, "blue"));
            fleet.Add(new Drone(40, 10, "blue"));
            fleet.Add(new Drone(40, 10, "blue"));
            fleet.Add(new Drone(40, 10, "Mirorange"));
            fleet.Add(new Drone(40, 10, "Pierre"));

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
                fleet.Add(new Drone(40, 10, "purple"));
                fleet.Add(new Drone(40, 10, "yellow"));
                fleet.Add(new Drone(40, 10, "red"));
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