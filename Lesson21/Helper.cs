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

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            road.Number = "M" + rnd.Next(1, 100);
            road.Lenght = rnd.Next(min, max);
            return road;
        }
    }
}
