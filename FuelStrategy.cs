using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_app
{
    internal class FuelStrategy
    {
        public void SwitchToEfficiencyMode(Car car)
        {
            car.AdjustSpeed(-20); // Зменшуємо швидкість для економії палива
            Console.WriteLine("Перемикання на режим економії палива.");
        }

        public void SwitchToAggressiveMode(Car car)
        {
            car.AdjustSpeed(20); // Збільшуємо швидкість для агресивної стратегії
            Console.WriteLine("Перемикання на агресивний режим.");
        }
    }
}
