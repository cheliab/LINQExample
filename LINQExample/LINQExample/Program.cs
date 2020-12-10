using System;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //  - Примеры простой выборки
            // SimpleExample.StartWithBasicExample();
            // SimpleExample.StartLINQExample();
            // SimpleExample.StartLinqExtentionExample();
            // SimpleExample.StartCombineExample();
            
            //  - Фильтры и др.
            // SecondExample.WhereExample();
            // SecondExample.WhereSecondExample();
            // SecondExample.ComplexFilterExample();
            // SecondExample.SelectFieldExample();
            // SecondExample.SelectAnonymousType();
            // SecondExample.SelectFromMultipleSources();
            
            //  - Сортировка
            // SortExamples.FirstExample();
            // SortExamples.SortComplexObjects();
            // SortExamples.MultiSortExample();
            
            //  - Отложенное и немедленное выполнение 
            // ImmediateExecutionExample.FirstExample();
            // ImmediateExecutionExample.SecondExample();
            // ImmediateExecutionExample.ThirdExample();
            ImmediateExecutionExample.FourthExample();

            Console.ReadLine();
        }
    }
}