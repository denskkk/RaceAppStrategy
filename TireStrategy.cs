using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_app
{
    internal class TireStrategy
    {
        public void UseAggressiveTireStrategy(Car car)
        {
            car.AdjustSpeed(10); // Підвищуємо швидкість, але шини швидше зношуються
            Console.WriteLine("Агресивна стратегія шин активована.");
        }

        public void UseConservativeTireStrategy(Car car)
        {
            car.AdjustSpeed(-10); // Знижуємо швидкість для збереження шин
            Console.WriteLine("Обережна стратегія шин активована.");
        }
    }
}
