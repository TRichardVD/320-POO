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

            Console.WriteLine($"Caractéristiques de l'objet se nommant {this} : x = {x}, y = {y}, width = {width}, depth = {Depth}, color = {color}");
        }
    }


    public class Factory : Building
    {
        public double PowerConsumption = 0;      // Nbr de KwH/jours de consommation de l'usine
        public Factory(int x, int y, int width, double powerConsumption, Color color = default) : base(x, y, width, width, color)
        {
            PowerConsumption = powerConsumption;

            Console.WriteLine($"Caractéristiques de l'objet se nommant {this} : x = {x}, y = {y}, width = {width}, powerConsumption = {PowerConsumption}, color = {color}");

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

            Console.WriteLine($"\nCaractéristiques de l'objet de type {this} : x = {x}, y = {y}, width = {width}, openingHours = {textOpeningHours}, color = {color}");
            
        }

        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(_brush, X, Y, Width, Depth);
        }
    }

}
