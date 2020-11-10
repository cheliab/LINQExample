using System;
using System.Linq;

namespace LINQExample
{
    /// <summary>
    /// Фильтрация выборки и проекция
    /// </summary>
    public class SecondExample
    {
        public static void WhereExample()
        {
            int[] numbers = {1, 2, 3, 4, 10, 20, 34, 54, 66, 77, 88};

            var firstResult = from number in numbers
                where number % 2 == 0 && number > 10
                select number;

            Console.WriteLine("firstResult:");
            foreach (var number in firstResult)
                Console.WriteLine(number);
                
            var secondResult = numbers.Where(n => n % 2 == 0 && n > 10);

            Console.WriteLine("secondResult:");
            foreach (var number in secondResult)
                Console.WriteLine(number);
        }
    }
}