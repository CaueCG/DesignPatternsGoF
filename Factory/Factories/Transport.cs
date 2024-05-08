using Factory.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    abstract class Transport
    {
        public void StartTransport()
        {
            IVehicles vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        protected abstract IVehicles CreateTransport();
    }
}
