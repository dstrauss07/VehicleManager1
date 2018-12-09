using Dstrauss.VehicleManager1;
using System;

namespace VehicleManager1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVehicle = new Vehicle
            {
                Year = 2018,
                Make = "Ford",
                Model = "Fusion"
            };

            var myCar1 = new Car
            {
                Year = 2017,
                Make = "Honda",
                Model = "Civic",
                NumberOfDoors = 4,
                TrunkSpaceInCubicFeet = 15.2M
            };

            var myVehicle2 = new Vehicle(2012, "Nissan", "Murano");

            Car myCar3 = new Car(2014, "Toyota", "Celica");

            Car myCar2 = new Car(2012, "Nissan", "Sentra", 4, 13.5M);

            LogVehicleName(myVehicle);
            LogVehicleName(myCar1);
            LogVehicleName(myVehicle2);

            //Vehicle myVehicle = new Vehicle();
            //myVehicle.year = 2018;
            //myVehicle.SetYear(2018);

            //Console.WriteLine($"{myCar1.GetFullName()}");
            Console.ReadLine();
        }

        private static void LogVehicleName(Vehicle veh)
        {
            Console.WriteLine(veh.GetFullName());
        }
    }
}
