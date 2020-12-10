using System;
using System.Collections.Generic;
using System.Linq;
using LINQExample.Objects;

namespace LINQExample
{
    public class SortExamples
    {
        /// <summary>
        /// Простая сортировка
        /// </summary>
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
            
            Console.WriteLine(new string('-', 20));

            var descSortedUsers = from dUser in users
                orderby dUser.Name descending
                select dUser;

            foreach (var user in descSortedUsers)
            {
                Console.WriteLine(user.Name);
            }
        }

        /// <summary>
        /// Использование методов расширений при сортировке
        /// </summary>
        public static void ThirdExample()
        {
            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };
            var sortedNumbers = numbers.OrderBy(number => number);
            
            List<User> users = new List<User>
            {
                new User {Name = "Владимир", Age = 23 },
                new User {Name = "Генадий", Age = 20 },
                new User {Name = "Борис", Age = 23 },
                new User {Name = "Аркадий", Age = 24 }
            };

            var sortedUsers = users.OrderBy(user => user.Name);

            var descSortUsers = users.OrderByDescending(user => user.Name);
        }

        /// <summary>
        /// Пример множественной сортировки
        /// </summary>
        public static void MultiSortExample()
        {
            List<User> users = new List<User>
            {
                new User { Name = "Паша", Age = 30 },
                new User { Name = "Вика", Age = 29 },
                new User { Name = "Макс", Age = 3 },
                new User { Name = "Аркадий", Age = 23 }
            };

            var result = from user in users
                orderby user.Name, user.Age
                select user;

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
            
            Console.WriteLine(new string('-', 20));

            var secondResult = users.OrderBy(u => u.Name).ThenBy(u => u.Age);

            foreach (var user in secondResult)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
        }
    }
}