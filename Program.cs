using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Autópark létrehozása
            CarPark carPark = new CarPark("Tesco Express parkoló", 4);
            //Autók hozzáadása
            carPark.AddCar(new Cars("Toyota", "Yaris", 4.5, 50, 2020, "piros"));
            carPark.AddCar(new Cars("Toyota", "Verso", 5.5, 40, 2018, "piros"));
            carPark.AddCar(new Cars("Toyota", "Avensis", 6.5, 30, 2019, "piros"));
            carPark.AddCar(new Cars("Toyota", "Hilux", 7.5, 60, 2021, "piros"));
            carPark.AddCar(new Cars("Toyota", "Truck", 5, 55, 2022, "piros"));

        }
    }
}
