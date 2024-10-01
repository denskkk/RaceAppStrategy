using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_app
{
    public class Car
    {
        public int Speed { get; set; }
        public double Fuel { get; set; }
        public int TireWear { get; set; }
        public int Position { get; set; }
        public int LapsCompleted { get; set; }

        public Car()
        {
            Speed = 100; // Початкова швидкість
            Fuel = 100.0; // Початковий рівень палива у відсотках
            TireWear = 0; // Шини не зношені
            Position = 1; // Початкове місце
            LapsCompleted = 0; // Кількість пройдених кіл
        }

        public void AdjustSpeed(int adjustment)
        {
            Speed += adjustment;
            Console.WriteLine($"Швидкість змінена на {Speed} км/год.");
        }

        public void ConsumeFuel()
        {
            Fuel -= Speed * 0.05; // Залежність споживання палива від швидкості
            if (Fuel < 0) Fuel = 0;
            Console.WriteLine($"Поточний рівень палива: {Fuel:F2}%");
        }

        public void WearTires()
        {
            TireWear += Speed / 20; // Чим вища швидкість, тим швидше зношуються шини
            if (TireWear > 100) TireWear = 100;
            Console.WriteLine($"Зношення шин: {TireWear}%");
        }

        public void UpdatePosition()
        {
            LapsCompleted++;
            Position = (new Random()).Next(1, 10); // Рандомна зміна позиції для спрощення
            Console.WriteLine($"Коло: {LapsCompleted}, Позиція: {Position}");
        }

        public void CompleteLap()
        {
            UpdatePosition();
            ConsumeFuel();
            WearTires();
        }
    }
}
