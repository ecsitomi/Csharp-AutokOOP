using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokOOP
{
    internal class CarPark
    {
        //Helyszín
        public string Location { get; set; }
        //Kapacitás
        public int Capacity { get; set; }
        //Nyitva-zárva
        public bool IsOpen { get; set; }
        //Összesített bevétel
        public int TotalCash { get; set; }
        //Dolgozók listája
        public List<string> Employees { get; set; }
        //Autók listája
        public List<Cars> cars { get; set; }

        //KONSTRUKTOR
        public CarPark(string location, int capacity)
        {
            this.Location = location;   
            this.Capacity = capacity;
            IsOpen = true;
            TotalCash = 0;
            Employees = new List<string>();
            cars = new List<Cars>();
        }

        //Autó hozzáadása
        public void AddCar(Cars car)
        {
            if (cars.Count<Capacity)
            {
                cars.Add(car);
                Console.WriteLine($"Hozzáadva {car.Brand} {car.Model}");
            } else
            {
                Console.WriteLine("Az autópark televan");
            }
        }
    }
}
