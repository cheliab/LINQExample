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
    
    class Phone 
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }

    /// <summary>
    /// Фильтрация выборки и проекция
    /// </summary>
    public class SecondExample
    {
        static List<User> users = new List<User>
        {
            new User { Name = "Павел", Age = 23, Languages = new List<string>{"английский", "немецкий"}},
            new User { Name = "Вика", Age = 25, Languages = new List<string>{"английский", "французский"}},
            new User { Name = "Макс", Age = 30, Languages = new List<string>{"английский", "испанский"}},
            new User { Name = "Артем", Age = 25, Languages = new List<string>{"английский", "португальский"}},
            new User { Name = "Петр", Age = 26, Languages = new List<string>{"немецкий", "португальский"}}
        };
        
        /// <summary>
        /// Выборка всех четных и больше 10
        /// </summary>
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
            var selectedUsers = from user in users where user.Age > 24 select user;

            foreach (var user in selectedUsers) 
                Console.WriteLine($"{user.Name} {user.Age}");

            var secondSelectedUsers = users.Where(user => user.Age > 24);

            foreach (var user in secondSelectedUsers)
                Console.WriteLine($"{user.Name} {user.Age}");
        }

        /// <summary>
        /// Пример сложного фильтра
        /// </summary>
        public static void ComplexFilterExample()
        {
            var selectedUsers = from user in users
                from language in user.Languages
                where user.Age < 28
                where language == "португальский"
                select user;

            foreach (var selectedUser in selectedUsers)
                Console.WriteLine(selectedUser.Name + " - " + selectedUser.Age);

            var secondSelectedUsers = users.SelectMany(user => user.Languages,
                    (user, lang) => new {User = user, Language = lang})
                .Where(user => user.Language == "португальский" && user.User.Age < 28)
                .Select(user => user.User);
        }

        /// <summary>
        /// Пример проекции - Получаем свойство
        /// </summary>
        public static void SelectFieldExample()
        {
            var names = from user in users select user.Name;

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine(new string('-', 20));

            var namesSecond = users.Select(user => user.Name);

            foreach (var name in namesSecond)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Пример проекции - Анонимные типы
        /// </summary>
        public static void SelectAnonymousType()
        {
            var items = from user in users
                select new
                {
                    FirstName = user.Name,
                    DateOfBirth = DateTime.Now.Year - user.Age
                };

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(new string('-', 20));

            var secondItems = users.Select(user => new
            {
                FirstName = user.Name, 
                DateOfBirth = DateTime.Now.Year - user.Age
            });

            foreach (var item in secondItems)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Выборка из нескольких источников
        /// </summary>
        public static void SelectFromMultipleSources()
        {
            List<User> users = new List<User>
            {
                new User { Name = "Макс", Age = 3 },
                new User { Name = "Паша", Age = 30 }
            };
            
            List<Phone> phones = new List<Phone>
            {
                new Phone { Name = "iPhone 12", Company = "Apple" },
                new Phone { Name = "Mi 10", Company = "Xiaomi" }
            };

            var people = from user in users
                from phone in phones
                select new {Name = user.Name, Phone = phone.Name};

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Phone}");
            }
        }
    }
}