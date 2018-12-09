using System;
using System.Collections.Generic;
using System.Text;

namespace Dstrauss.VehicleManager1
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string GetFullName()
        {
            return $"{Year} {Make} {Model}";
        }

        


        //public int Year
        //{
        //    get { return year; }
        //    set { year = value; }
        //}

        //public int getyear()
        //{
        //    return year + 1;
        //}

        //public void setyear(int newyear)
        //{
        //    year = newyear;
        //}

    }
}
