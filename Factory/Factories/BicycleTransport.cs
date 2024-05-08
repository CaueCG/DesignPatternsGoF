using Factory.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    internal class BicycleTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Bicycle();
        }
    }
}
