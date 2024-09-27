using System.Reflection.Metadata;

namespace Drones
{
    public enum EvacuationState
    {
        Free,           // No limits applied
        Evacuating,     // Limits known, moving out of the zone
        Evacuated       // Limits known, out of the zone
    }
    public interface IExpellable
    {
        // Signal the limits of the no-fly zone 
        // Return true if the drone is already outside the zone
        public bool Evacuate(Rectangle zone);

        // Terminate the no-fly zone
        public void FreeFlight();

        // Interrogate the drone
        public EvacuationState GetEvacuationState();
    }

    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        public const int WIDTH = 1200;        // Dimensions of the airspace
        public const int HEIGHT = 600;

        public const byte MAX_LENGTH_OF_FLEET = 10;

        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Drone>? fleet;
        private List<Building>? Buildings;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building>? buildings = null)
        {
            if (fleet.Count <= MAX_LENGTH_OF_FLEET)
                this.fleet = fleet;
            else
            {
                throw new ArgumentException($"Le paramètre est trop grand. La limite est de {MAX_LENGTH_OF_FLEET}.", nameof(fleet));

            }
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            
            
            this.Buildings = buildings;
            
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            if (this.fleet != null)
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
            }

            if (this.Buildings != null)
                foreach(Building building in Buildings)
                {
                    switch(building)
                    {
                        case Store store:
                            store.Render(airspace);
                            break;
                        case Factory factory:
                            factory.Render(airspace);
                            break;
                        default:
                            building.Render(airspace);
                            break;
                    }
                }
            airspace.Render();
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            if (fleet != null)
                foreach (Drone drone in fleet)
                    {
                        drone.Update(interval);
                    }
        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}