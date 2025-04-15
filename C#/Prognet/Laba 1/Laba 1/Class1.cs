using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Class1
    {
        public static double Task1(double a, double b)
        {
            return -b / a;
        }

        public static double Task2(double x, double y)
        {
            return x > y ? x : y;
        }

        public static string Task3(int k)
        {
            int lastChislo = k % 10;
            int lastTwoChisla = k % 100;

            if (lastChislo == 1 && lastTwoChisla != 11)
                return $"Мы нашли {k} гриб в лесу";
            else if (lastChislo >= 2 && lastChislo <= 4 && (lastTwoChisla < 12 || lastTwoChisla > 14))
                return $"Мы нашли {k} гриба в лесу";
            else
                return $"Мы нашли {k} грибов в лесу";
        }

        public static string Task4(double circleArea, double squareArea)
        {
            double circleDiameter = 2 * Math.Sqrt(circleArea/ Math.PI);
            double squareSide = Math.Sqrt(squareArea);
            double squareDiagonal = Math.Sqrt(2) * squareSide;

            string result = "";

            if (squareDiagonal <= circleDiameter)
                result += "Kvadrat pomeshietsya v krug. ";
            else
                result += "Kvadrat pomeshietsya v krug. ";

            if (circleDiameter <= squareSide)
                result += "Krug pomeshyatsya v kvadrat. ";
            else
                result += "Krug ne pomeshyatsya v kvadrat.";

            return result;
        }

        public static string Task5(double KmHm, double MS)
        {
            double convertor = KmHm * 1000 / 3600;
            if (convertor > MS) return $"Skorost v km/ch bolshe";
            else if (convertor < MS) return $"Skorost v ms/s bolshe";
            else return $"Skorosti ravny";
        }

        public static int Task6(int pastYear, int pastMonth, int newYear, int newMonth)
        {
            int age = newYear - pastYear;
            if(newMonth < pastMonth)
            {
                age--;
            }
            return age;
        }

        public static string Task7(string lastName)
        {
            if (lastName.EndsWith("ов"))
                return $"Здравствуйте, господин {lastName}!";
            else if (lastName.EndsWith("ова"))
                return $"Здравствуйте, госпожа {lastName}!";
            else
                return $"Здравствуйте, {lastName}!";
        }
        public static string Task8(string day)
        {
            switch (day.ToLower())
            {
                case "понедельник": return "Лекция по математике";
                case "вторник": return "Практика по программированию";
                case "среда": return "Лекция по физике";
                case "четверг": return "Лабораторная по информатике";
                case "пятница": return "Семинар по истории";
                case "суббота": return "Спортивные мероприятия";
                case "воскресенье": return "Выходной";
                default: return "Такого дня недели нет!";
            }
        }
    }
}
