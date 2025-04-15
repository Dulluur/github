using System;

namespace CarLab2
{
    internal abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; protected set; }
        public int MaxSpeed { get; protected set; }
        public Radio CarRadio { get; set; } = new Radio();
        public bool IsStarted { get; private set; } = false; 

        public Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Speed = 0;
        }

        public void Start()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                Console.WriteLine($"{Name} заведен.");
            }
            else
            {
                Console.WriteLine($"{Name} уже заведен.");
            }
        }

        public void Stop()
        {
            if (!IsStarted)
            {
                Console.WriteLine($"{Name} уже заглушен.");
                return;
            }

            if (Speed > 0)
            {
                Console.WriteLine($"Невозможно сразу заглушить {Name} на скорости {Speed} км/ч! Сначала замедлитесь.");
                return;
            }

            IsStarted = false;
            Console.WriteLine($"{Name} остановлен и заглушен.");
        }

        public void SpeedUp(int increment)
        {
            if (!IsStarted)
            {
                Console.WriteLine($"Невозможно ускориться. {Name} не заведен.");
                return;
            }

            if (Speed + increment <= MaxSpeed)
            {
                Speed += increment;
                Console.WriteLine($"{Name} ускорился до {Speed} км/ч.");
            }
            else
            {
                Speed = MaxSpeed;
                Console.WriteLine($"{Name} достиг максимальной скорости {MaxSpeed} км/ч.");
            }
        }

        public void SpeedDown(int decrement)
        {
            if (!IsStarted)
            {
                Console.WriteLine($"Невозможно замедлиться. {Name} не заведен.");
                return;
            }

            Speed = Math.Max(0, Speed - decrement);
            Console.WriteLine($"{Name} замедлился до {Speed} км/ч.");
        }
    }

    internal class Radio
    {
        public void On()
        {
            Console.WriteLine("Радио включено.");
        }

        public void Off()
        {
            Console.WriteLine("Радио выключено.");
        }
    }
}
