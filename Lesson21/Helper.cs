using System;
using System.Collections;
using System.Linq;

namespace Lesson21
{
    public static class Helper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool IsDividedBy(this int i, int j)
        {
            return i % j == 0;
        }

        public static string CovenvertToString(this IEnumerable collection)
        {
            var result = "";

            foreach(var item in collection)
            {
                result += item.ToString() + ", \r\n";
            }

            return result;
        }

        private static Random rnd = new Random();

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {            
            road.Number = "M" + rnd.Next(1, 100);
            road.Lenght = rnd.Next(min, max);
            return road;
        }
    }
}
