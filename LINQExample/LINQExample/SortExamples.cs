using System;
using System.Linq;

namespace LINQExample
{
    public class SortExamples
    {
        public static void FirstExample()
        {
            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };
            var orderedNumbers = from number in numbers
                orderby number
                select number;

            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}