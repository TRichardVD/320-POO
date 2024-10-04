using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    internal class Dispatch
    {
        private List<Box> boxes = new List<Box>();

        public Dispatch() 
        { 
            
        }

        public void Warn(Box box)
        {
            boxes.Add(box);
        }
    }
}
