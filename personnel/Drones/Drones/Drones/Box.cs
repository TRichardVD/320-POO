using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    internal class Box
    {
        public readonly int id;
        public int NbrKilos = 0;
        public readonly Color SmartiesColor;
        public readonly int IdCreator;

        private int NbrBoxes = 0;

        public Box(int idCreator, int nbrkilos, Color SmartiesColor) 
        {
            this.SmartiesColor = SmartiesColor;
            this.NbrKilos = nbrkilos;
            this.IdCreator = idCreator;

            this.id = NbrBoxes++;

        }



    }
}
