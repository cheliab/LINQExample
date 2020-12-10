using System;
using System.Collections.Concurrent;
using System.Linq;

namespace LINQExample
{
    public class ImmediateExecution
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
    }
}