using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_app
{   

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення об'єктів
            Car car = new Car();
            FuelStrategy fuelStrategy = new FuelStrategy();
            TireStrategy tireStrategy = new TireStrategy();
            PitStop pitStop = new PitStop();

            // Гонка 1
            Race race1 = new Race(10, "Sunny");
            Console.WriteLine("Гонка 1 (Сонячна погода):");
            race1.StartRace(car, fuelStrategy, tireStrategy);

            // Погана погода - Дощ
            Race race2 = new Race(5, "Rain");
            Console.WriteLine("\nГонка 2 (Дощ):");
            race2.AdjustForWeather(car);
            race2.StartRace(car, fuelStrategy, tireStrategy);

            // Використання функцій піт-стопу поза гонкою
            Console.WriteLine("\nПіт-стоп між гонками:");
            pitStop.Refuel(car);
            pitStop.ChangeTires(car);
            pitStop.RepairCar(car);

            // Тестування стратегії палива та шин поза гонкою
            Console.WriteLine("\nТестування стратегій:");
            fuelStrategy.SwitchToEfficiencyMode(car);
            tireStrategy.UseConservativeTireStrategy(car);

            fuelStrategy.SwitchToAggressiveMode(car);
            tireStrategy.UseAggressiveTireStrategy(car);

            Console.WriteLine("\nКінець програми.");
        }
    }
}
