using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_app
{
    internal class PitStop
    {
        public void Refuel(Car car)
        {
            car.Fuel = 100;
            Console.WriteLine("Паливо заправлено до 100%.");
        }

        public void ChangeTires(Car car)
        {
            car.TireWear = 0;
            Console.WriteLine("Шини замінені на нові.");
        }

        public void RepairCar(Car car)
        {
            Console.WriteLine("Автомобіль відремонтовано.");
        }
    }
}
