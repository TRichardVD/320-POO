using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Building
    {

        private int x = 0;
        private int y = 0;

        private int Width = 0;
        private int Depth = 0;

        private Color color;



        SolidBrush BuildingBrush = new SolidBrush(Color.Red);

        public void Render(BufferedGraphics drawingSpace)
        {
            BuildingBrush.Color = color;
            drawingSpace.Graphics.FillRectangle(BuildingBrush, x, y, Width, Depth);

        }

        public Building (int x, int y, int Width, int Depth, Color color = default)
        {
            if (color == default)
            {
                color = Color.DarkGray;
            }

            this.x = x;
            this.y = y;
            this.Width = Width;
            this.Depth = Depth;
            this.color = color;


        }


    }
}
