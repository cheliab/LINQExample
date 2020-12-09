using System;
using System.Collections.Generic;
using System.Linq;
using LINQExample.Objects;

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

        /// <summary>
        /// Сортировка сложных объектов
        /// </summary>
        public static void SortComplexObjects()
        {
            List<User> users = new List<User>
            {
                new User {Name = "Владимир", Age = 23 },
                new User {Name = "Генадий", Age = 20 },
                new User {Name = "Борис", Age = 23 },
                new User {Name = "Аркадий", Age = 24 }
            };

            var sortedUsers = from user in users
                orderby user.Name
                select user;

            foreach (var user in sortedUsers)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}