using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_app
{
    internal class Race
    {
        public int LapCount { get; set; }
        public string Weather { get; set; }
        private PitStop pitStop = new PitStop();

        public Race(int lapCount, string weather)
        {
            LapCount = lapCount;
            Weather = weather;
        }

        public void StartRace(Car car, FuelStrategy fuelStrategy, TireStrategy tireStrategy)
        {
            for (int i = 1; i <= LapCount; i++)
            {
                Console.WriteLine($"\nКоло {i}:");
                car.CompleteLap();

                if (car.Fuel < 30 || car.TireWear > 70)
                {
                    Console.WriteLine("Час заїхати на піт-стоп.");
                    MakePitStop(car);
                }

                if (i % 3 == 0)
                {
                    tireStrategy.UseAggressiveTireStrategy(car);
                    fuelStrategy.SwitchToAggressiveMode(car);
                }
                else
                {
                    tireStrategy.UseConservativeTireStrategy(car);
                    fuelStrategy.SwitchToEfficiencyMode(car);
                }
            }

            Console.WriteLine($"Гонка завершена. Автомобіль пройшов {car.LapsCompleted} кіл.");
        }

        public void MakePitStop(Car car)
        {
            pitStop.Refuel(car);
            pitStop.ChangeTires(car);
            Console.WriteLine("Піт-стоп завершено.");
        }

        public void AdjustForWeather(Car car)
        {
            if (Weather == "Rain")
            {
                car.AdjustSpeed(-20);
                Console.WriteLine("Швидкість знижена через дощ.");
            }
        }
    }
}
