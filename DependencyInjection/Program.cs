using System;
using System.Collections.Generic;
using System.Diagnostics;
using FirstTry.strategyPattern;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main()
        {
            var ducks = new DuckFactory().CreateDucks();

            for (int i = 0; i < ducks.Count; i++)
            {
                DoDuckThings(ducks[i], i+1);
            }

            Console.ReadKey();
        }

        private static void DoDuckThings(Duck duck, int number)
        {
            Console.WriteLine(number + " duck");

            duck.PerformFly();
            duck.PerformQuack();
            duck.PerformSwim();

            Console.WriteLine("\n");
        }
    }
}
