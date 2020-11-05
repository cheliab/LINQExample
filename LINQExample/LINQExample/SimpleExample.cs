using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    public class SimpleExample
    {
        private static string[] films =
        {
            "От заката до рассвета", "Ритуал", "Солнцестояние", 
            "Бешенные псы", "Криминальное чтиво"
        };
        
        public static void StartWithBasicExample()
        {
            var selectedFilms = new List<string>();
            foreach (string film in films)
            {
                if (film.ToUpper().StartsWith("Б"))
                    selectedFilms.Add(film);
            }
            selectedFilms.Sort();

            foreach (string selectedFilm in selectedFilms)
            {
                Console.WriteLine(selectedFilm);
            }
        }
        
        public static void StartLINQExample()
        {
            var selectedFilms = from film in films
                where film.ToUpper().StartsWith("Б")
                orderby film
                select film;

            foreach (string selectedFilm in selectedFilms)
            {
                Console.WriteLine(selectedFilm);
            }
        }
    }
}