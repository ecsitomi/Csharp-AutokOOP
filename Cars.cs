using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokOOP
{
    internal class Cars
    {
        //Márka
        public string Brand {  get; set; }
        //Modell
        public string Model { get; set; }
        //Sebesség
        public int Speed { get; set; }
        //Fogyasztás
        public double FuelConsumption { get; set; }
        //Akt üzemanyag literben
        public double FuelLevel { get; set; }
        //Gyártási év
        public int Year { get; set; }
        //Szín
        public string Color { get; set; }
        //Motor állapota
        public bool Running { get; set; }

        //KONSTRUKTOR
        public Cars(string brand, string model, double fuelconsumption, double fuellevel, int year, string color)
        {
            Brand = brand;
            Model = model;
            FuelConsumption = fuelconsumption;
            FuelLevel = fuellevel;
            Year = year;
            Color = color;
            //Running = running;

        }
    }
}
