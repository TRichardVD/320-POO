namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        const int baseCharge = 1000;
        const double IsLowbattery = 0.2;



        public int charge { get; set; } = baseCharge ;                // La charge actuelle de la batterie
        private string name;                                            // Un nom
        private int x;                                                  // Position en X depuis la gauche de l'espace aérien
        private int y;                                                  // Position en Y depuis le haut de l'espace aérien
        public bool LowBatterie = false;                                // Batterie faible à 20%

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += helper.rdm(-2, 3);                    // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            
            if (charge > 0)
                charge--;                                  // Il a dépensé de l'énergie

            if (charge <= IsLowbattery*baseCharge)
                this.LowBatterie = true;
        }

        public Drone(string Name, int X, int Y)
        {
            name = Name;
            x = X;
            y = Y;
        }

    }
}
