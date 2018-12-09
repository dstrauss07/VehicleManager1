using System;
using System.Collections.Generic;
using System.Text;

namespace Dstrauss.VehicleManager1
{

    public class Car: Vehicle
    {
        public Car()
        {

        }

        public Car(int year, string make, string model) : base(year, make, model)
        {
        }

        public Car(int year, string make, string model, int numberOfDoors, decimal trunkSpace) : base(year, make, model)
        {
            NumberOfDoors = numberOfDoors;
            TrunkSpaceInCubicFeet = trunkSpace;
        }


        public int NumberOfDoors { get; set; }
        public decimal TrunkSpaceInCubicFeet { get; set; }
    }
}
