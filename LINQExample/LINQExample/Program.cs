using System;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleExample.StartWithBasicExample();
            SimpleExample.StartLINQExample();
            SimpleExample.StartLinqExtentionExample();
            SimpleExample.StartCombineExample();
            
            Console.ReadLine();
        }
    }
}