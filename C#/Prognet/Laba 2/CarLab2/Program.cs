using System;
using CarLab2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Выберите автомобиль:");
        Console.WriteLine("1. Toyota");
        Console.WriteLine("2. Ferrari");
        Console.WriteLine("3. Bugatti");
        Console.Write("Ваш выбор: ");

        int choice = int.Parse(Console.ReadLine());
        Car car = null;

        switch (choice)
        {
            case 1:
                car = new Toyota();
                break;
            case 2:
                car = new Ferrari();
                break;
            case 3:
                car = new Buggati();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }

        Console.WriteLine($"\nВы выбрали {car.Name}.");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Завести автомобиль");
            Console.WriteLine("2. Включить радио");
            Console.WriteLine("3. Выключить радио");
            Console.WriteLine("4. Ускориться");
            Console.WriteLine("5. Замедлиться");
            Console.WriteLine("6. Остановить автомобиль");
            Console.WriteLine("7. Выход");
            Console.Write("Ваш выбор: ");

            if (!int.TryParse(Console.ReadLine(), out int action))
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите число от 1 до 7.");
                continue;
            }

            switch (action)
            {
                case 1:
                    car.Start();
                    break;
                case 2:
                    car.CarRadio.On();
                    break;
                case 3:
                    car.CarRadio.Off();
                    break;
                case 4:
                    Console.Write("Введите значение для ускорения: ");
                    if (int.TryParse(Console.ReadLine(), out int increment))
                        car.SpeedUp(increment);
                    else
                        Console.WriteLine("Ошибка ввода. Введите число.");
                    break;
                case 5:
                    Console.Write("Введите значение для замедления: ");
                    if (int.TryParse(Console.ReadLine(), out int decrement))
                        car.SpeedDown(decrement);
                    else
                        Console.WriteLine("Ошибка ввода. Введите число.");
                    break;
                case 6:
                    car.Stop();
                    break;
                case 7:
                    running = false;
                    Console.WriteLine("Завершение программы...");
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}
