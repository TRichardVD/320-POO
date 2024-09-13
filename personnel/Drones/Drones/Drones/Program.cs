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
            fleet.Add(drone);

            List<Building> buildings = new List<Building>
            {
                {new Building(300, 300, 200, 600) }
            };

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}