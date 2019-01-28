
using System;
using System.Collections.Generic;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // В своей предметной области поработать с методами расширения
            // Создать метод расширения для стандартного типа данных
            // Создать метод расширения для интерфейса
            // *Создать метод расширения для sealed-класса из внешней библиотеки

            Console.Write("Введите число: ");
            var input = Console.ReadLine();

            if(int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                if(result.IsEven())
                {
                    Console.WriteLine($"{result} - Четное.");
                }
                else
                {
                    Console.WriteLine($"{result} - Нечетное.");
                }

                int h = 182;
                h.IsDividedBy(7);
            }
            else
            {
                Console.WriteLine("Это не целое число");
            }

            Console.ReadLine();

            var roads = new List<Road>();
            for(var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.CovenvertToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }
    }
}
