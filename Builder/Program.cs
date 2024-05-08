using Builder.Builders;
using Builder.Directors;
using Builder.Products;

VehicleBuilder builder = new VehicleBuilder();
Director director = new Director(builder);

director.ConstructSedanCar();
Vehicle sedan = builder.GetVehicle();
Console.WriteLine($"Criado um veículo do tipo: {sedan.vehicleType}");

director.ConstructTruck();
Vehicle truck = builder.GetVehicle();
Console.WriteLine($"Criado um veículo do tipo: {truck.vehicleType}");

Console.ReadLine();