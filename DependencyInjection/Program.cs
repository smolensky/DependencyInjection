using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstTry.strategyPattern;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
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
            return new List<Duck> {new RubberDuck(), new WoodenDuck(), new SimpleDuck(), new FakeDuck()};
        }
    }
}
