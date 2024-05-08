using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine _engine)
        {
            vehicle.engine = _engine;
        }

        public void SetSeats(int _seats)
        {
            vehicle.seats = _seats;
        }

        public void SetTransmission(Transmission _transmission)
        {
            vehicle.transmission = _transmission;
        }

        public void SetVehicleType(VehicleType _vehicleType)
        {
            vehicle.vehicleType = _vehicleType;
        }
    }
}
