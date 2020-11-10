using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }

        public User()
        {
            Languages = new List<string>();
        }
    }
    
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

        /// <summary>
        /// Выборка сложных объектов
        /// </summary>
        public static void WhereSecondExample()
        {
            List<User> users = new List<User>
            {
                new User { Name = "Павел", Age = 23, Languages = new List<string>{"английский", "немецкий"}},
                new User { Name = "Вика", Age = 25, Languages = new List<string>{"английский", "французский"}},
                new User { Name = "Макс", Age = 30, Languages = new List<string>{"английский", "испанский"}}
            };

            var selectedUsers = from user in users where user.Age > 24 select user;

            foreach (var user in selectedUsers) 
                Console.WriteLine($"{user.Name} {user.Age}");

            var secondSelectedUsers = users.Where(user => user.Age > 24);

            foreach (var user in secondSelectedUsers)
                Console.WriteLine($"{user.Name} {user.Age}");
        }
    }
}