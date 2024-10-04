using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public abstract class Building
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public int Width { get; private set; }
        public int Depth { get; private set; }

        public readonly Color Color;

        readonly protected SolidBrush _brush;

        public virtual void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(_brush, X, Y, Width, Depth);
        }

        public Building(int x, int y, int width, int depth, Color color = default)
        {
            if (color == default)
            {
                color = Color.DarkGray;
            }

            X = x;
            Y = y;
            Width = width;
            Depth = depth;

            Color = color;
            _brush = new SolidBrush(color);

            Console.WriteLine($"Caractéristiques de l'objet de type {this} : \n\tx = {x}\n\ty = {y}\n\twidth = {width}\n\tdepth = {Depth}\n\tcolor = {color}");
        }
    }


    public class Factory : Building
    {
        const int boxCreationDuration = 50;
        private int TimeSpentToCreateABox = 0;
        private static int nbrFactory = 0;
        public readonly int Id;
        public double PowerConsumption = 0;      // Nbr de KwH/jours de consommation de l'usine
        private List<Box> BoxCreated = new List<Box>();


        public Factory(int x, int y, int width, double powerConsumption, Color color = default) : base(x, y, width, width, color)
        {
            PowerConsumption = powerConsumption;

            Id = nbrFactory++;

            Console.WriteLine($"\tpowerConsumption = {PowerConsumption}\n\tIdentifiant unique = {Id}\n\n");
            

        }

        public void Update()
        {
            if (TimeSpentToCreateABox >= boxCreationDuration)
            {
                if (Helper.rdm(1, 10) > 3)
                {
                    
                    // Création d'une nouvelle box
                    BoxCreated.Add(
                        new Box(Id, Helper.rdm(5, 11), Color.Blue)
                        );
                    Console.WriteLine($"L\'usine {Id} à créé son {BoxCreated.Count} packet de smarties de couleur {BoxCreated.Last<Box>().SmartiesColor} avec l'identifiant {BoxCreated.Last<Box>().id} et de {BoxCreated.Last<Box>().NbrKilos} Kilos!");
                }
                TimeSpentToCreateABox = 0;
            }
            else
                ++TimeSpentToCreateABox;

        }

    }

    public class Store : Building
    {
        List<string> OpeningHours = new List<string>();

        public Store(int x, int y, int width, List<string> openingHours, Color color = default) : base(x, y, width, width, color)
        {
            OpeningHours = openingHours;

            string textOpeningHours = "";
            foreach (string openingHour in OpeningHours)
            { textOpeningHours += $" {openingHour},"; }

            Console.WriteLine($"\topeningHours = {textOpeningHours}\n\n");
            
        }

        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(_brush, X, Y, Width, Depth);
        }
    }

}
