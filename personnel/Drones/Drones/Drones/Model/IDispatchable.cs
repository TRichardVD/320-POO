using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    interface IDispatchable
    {
        void WarnBox(Box box);

        void RmvBox(Box box);
    }
}
