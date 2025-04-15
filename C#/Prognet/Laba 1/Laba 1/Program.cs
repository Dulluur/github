using System;
using System.Security.Cryptography.X509Certificates;

namespace Laba_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"Reshenie 1 taska: x = {Class1.Task1(5, 10)}");
            Console.WriteLine($"Reshenie 2 taska: max = {Class1.Task2(3.2, 4.8)}");
            Console.WriteLine($"Reshenie 3 taska: k = {Class1.Task3(1413)}");
            Console.WriteLine($"Reshenie 4 taska: k = {Class1.Task4(12, 32)}");
            Console.WriteLine($"Reshenie 5 taska: {Class1.Task5(100, 200)}");
            Console.WriteLine($"Reshenie 6 taska: Vozrast = {Class1.Task6(2000, 5, 2024, 4)}");
            Console.WriteLine($"Reshenie 7 taska: {Class1.Task7("Петров")}");
            Console.WriteLine($"Reshenie 8 taska: {Class1.Task8("ПОНЕдеЛЬник")}");
        }
    }
}
