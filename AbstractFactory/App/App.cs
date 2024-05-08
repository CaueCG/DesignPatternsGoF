using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    internal class App
    {
        private IAircraft aircraft;
        private ILandVehicles vehicle;

        public App(ITransportFactory factory)
        {

            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
