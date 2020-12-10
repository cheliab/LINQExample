using System;
using System.Collections.Concurrent;
using System.Linq;

namespace LINQExample
{
    public class ImmediateExecutionExample
    {
        
        /// <summary>
        /// Пример отложенного выполнения
        /// </summary>
        public static void FirstExample()
        {
            string[] teams = {"Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона"};

            // создается запрос
            var selectedTeams = from team in teams
                where team.ToUpper().StartsWith("Б")
                orderby team
                select team;

            // изменяем массив после создания запроса
            teams[0] = "Ювентус";
            teams[1] = "Челси";

            // выполнение запроса
            foreach (var team in selectedTeams)
            {
                Console.WriteLine(team);
            }
        }

        /// <summary>
        /// Пример немедленного выполнения запроса
        /// </summary>
        public static void SecondExample()
        {
            string[] teams = {"Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона"};

            int i = (from t in teams
                where t.ToUpper().StartsWith("Б")
                orderby t
                select t).Count();
            
            Console.WriteLine(i);

            teams[0] = "Ювентус";
            
            Console.WriteLine(i);
        }
        
        /// <summary>
        /// Пример когда Count учитывает изменения в массиве
        /// </summary>
        public static void ThirdExample()
        {
            string[] teams = {"Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона"};

            var selectedTeams = from t in teams
                where t.ToUpper().StartsWith("Б")
                orderby t
                select t;
            
            Console.WriteLine(selectedTeams.Count());

            teams[0] = "Ювентус";
            
            Console.WriteLine(selectedTeams.Count());
        }
    }
}