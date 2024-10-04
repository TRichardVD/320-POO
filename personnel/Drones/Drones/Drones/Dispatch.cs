using Drones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    internal class Dispatch : IDispatchable
    {
        private List<Box> boxes = new List<Box>();

        public Dispatch() 
        { 
            
        }

        public void WarnBox(Box box)
        {
            boxes.Add(box);
        }

        public void RmvBox(Box box)
        {
            boxes.Remove(box);
        }


    }
}
