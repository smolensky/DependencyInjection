using System;
using System.Collections.Generic;
using FirstTry.strategyPattern;
using FirstTry.strategyPattern.Ducks;

namespace DependencyInjection
{
    class Program
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
            duck.Swim();

            Console.WriteLine("\n");
        }
    }

    internal class DuckFactory
    {
        public List<Duck> CreateDucks()
        {
            return new List<Duck>
            {
                //new RubberDuck(), new WoodenDuck(), new SimpleDuck(), new FakeDuck()
            };
        }
    }
}
