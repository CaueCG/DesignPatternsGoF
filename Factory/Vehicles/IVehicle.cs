using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Vehicles
{
    internal interface IVehicles
    {
        public void GetCarga();
        public void StartRoute();
    }
}
