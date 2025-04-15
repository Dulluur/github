using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class Car
    {
            public string Model { get; set; }
            public int Speed { get; protected set; }
            public int MaxSpeed { get; protected set; }
            public Radio CarRadio { get; set; } = new Radio();

            public Car(string model, int maxSpeed)
            {
                Model = model;
                MaxSpeed = maxSpeed;
                Speed = 0;
            }

            public void Start()
            {
                Console.WriteLine($"{Model} заведен.");
            }

            public void Stop()
            {
                Speed = 0;
                Console.WriteLine($"{Model} остановлен.");
            }

            public void Speedup(int increment)
            {
                if (Speed + increment <= MaxSpeed)
                {
                    Speed += increment;
                    Console.WriteLine($"{Model} ускорился до {Speed} км/ч.");
                }
                else
                {
                    Speed = MaxSpeed;
                    Console.WriteLine($"{Model} достиг максимальной скорости {MaxSpeed} км/ч.");
                }
            }

            public void Slowdown(int decrement)
            {
                Speed = Math.Max(0, Speed - decrement);
                Console.WriteLine($"{Model} замедлился до {Speed} км/ч.");
            }
        }

        internal class Toyota : Car
        {
            public Toyota() : base("Toyota", 300) { }
        }

        internal class Ferrari : Car
        {
            public Ferrari() : base("Ferrari", 350) { }
        }

        internal class Bugatti : Car
        {
            public Bugatti() : base("Bugatti", 400) { }
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
