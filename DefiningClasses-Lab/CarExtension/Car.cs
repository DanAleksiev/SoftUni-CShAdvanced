﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
    {
    internal class Car
        {

        //fields
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        //properties
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }


        //methods
        public void Drive(double distance)
            {
            double neededFuel = distance * fuelConsumption;

            if (neededFuel < fuelQuantity)
                {
                fuelQuantity -= neededFuel;
                }
            else
                {
                Console.WriteLine("Not enough fuel to perform this trip!");
                }
            }
        public string WhoAmI()
        {
            string output = $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:f2} ";
            return output ;
        }
    }
}
    

