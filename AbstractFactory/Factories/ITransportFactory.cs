﻿using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicles CreateTransportVehicle();
    }
}
