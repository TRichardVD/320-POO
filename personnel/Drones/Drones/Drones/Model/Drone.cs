
namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        const int BASE_CHARGE = 1000;                                   // Charge initialisé lors de la création du drone
        const double LOW_BATTERY_LIMIT = 0.2;                           // A partir de quel proportion de batterie "LowBatterie" est vrai



        public int charge { get; set; } = BASE_CHARGE ;                // La charge actuelle de la batterie
        private string name;                                            // Un nom
        private int x;                                                  // Position en X depuis la gauche de l'espace aérien
        private int y;                                                  // Position en Y depuis le haut de l'espace aérien
        public bool LowBatterie = false;                                // Batterie faible à 20%
        public List<Rectangle> NoFlyZones = new List<Rectangle>();
        

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += Helper.rdm(-2, 3);                    // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            
            if (charge > 0)
                charge--;                                  // Il a dépensé de l'énergie

            if (charge <= LOW_BATTERY_LIMIT*BASE_CHARGE)
                this.LowBatterie = true;
        }

        public bool Evacuate(Rectangle zone)
        {
            NoFlyZones.Add(zone);

            return !zone.IntersectsWith(new Rectangle(x, y, 5, 5));
        }

        public void FreeFlight()
        {
            NoFlyZones.Clear();
        }

        public EvacuationState GetEvacuationState()
        {
            if (NoFlyZones.Count == 0)
                return EvacuationState.Free;
            else
            {
                foreach (Rectangle NoFlyZone in NoFlyZones)
                {
                    if (NoFlyZone.IntersectsWith(new Rectangle(x, y, 5, 5)))
                        return EvacuationState.Evacuating;
                }
                return EvacuationState.Evacuated;
            }
        }

        // Constructeur du drone
        public Drone(int X, int Y, string Name = "DroneName")
        {
            x = X;
            y = Y;
            name = Name;
        }

        

    }
}
