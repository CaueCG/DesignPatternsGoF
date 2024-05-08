using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    internal class Vehicle
    {


        public VehicleType vehicleType {  get; set; }
        public int seats { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission {  get; set; }

    }
}
