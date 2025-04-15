using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Number num1 = new Number(10);
        Number num2 = new Number(20);

        Number result = num1 - num2;

        Console.WriteLine($"Результат операции num1 - num2: {result}");

        Console.WriteLine("\n 2 задача с планетами: ");
        Planet planets = new Planet(8);
        planets[0] = new Planet("Меркурий", 100);
        planets[1] = new Planet("Венера", 200);
        planets[2] = new Planet("Земля", 300);
        planets[3] = new Planet("Марс", 400);
        planets[4] = new Planet("Юпитер", 500);
        planets[5] = new Planet("Сатурн", 600);
        planets[6] = new Planet("Уран", 700);
        planets[7] = new Planet("Нептун", 800);

        Planet earth = planets[2];
        for (int i = 0; i < 8; i++)
        {
            if (planets[i].Radius > earth.Radius)
            {
                Console.WriteLine(planets[i].Name);
            }
        }

    }

    class Number
    {
        public int Value { get; } 

        public Number(int value)
        {
            Value = value;
        }

        public static Number operator - (Number a, Number b)
        {
            return new Number(a.Value + b.Value); 
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class Planet
    {
        public string Name { get; set; }
        public double Radius { get; set; }

        private Planet[] planetArr;

        public Planet(int index)
        {
            planetArr = new Planet[index];
        }

        public Planet(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public Planet this[int index]
        {
            get
            {
                return (planetArr[index]);
            }
            set
            {
                planetArr[index] = value;
            }
        }
    }
}