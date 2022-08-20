using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("enter a series of numbers separated by comma");
            var num = Console.ReadLine();
            var n = num.Split(",");
            var max = Convert.ToInt32(n[0]);

            foreach (var str in n)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is: max");


        }
    }
}