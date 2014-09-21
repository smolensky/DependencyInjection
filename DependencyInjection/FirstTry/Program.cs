using System;
using FirstTry.strategyPattern;

namespace FirstTry
{
    class Program
    {
        static void Main()
        {
            Duck littleDuck = new RubberDuck();
            Duck woodenDuck = new WoodenDuck();
            Duck simleDuck = new SimpleDuck();
            Duck fakeDuck = new FakeDuck();

            Console.WriteLine("1st duck");
            littleDuck.PerformFly();
            littleDuck.PerformQuack();
            littleDuck.Swim();

            Console.WriteLine("\n");

            Console.WriteLine("2nd duck");
            woodenDuck.PerformFly();
            woodenDuck.PerformQuack();
            woodenDuck.Swim();

            Console.WriteLine("\n");

            Console.WriteLine("3rd duck");
            simleDuck.PerformFly();
            simleDuck.PerformQuack();
            simleDuck.Swim();

            Console.WriteLine("\n");

            Console.WriteLine("4th duck");
            fakeDuck.PerformFly();
            fakeDuck.PerformQuack();
            fakeDuck.Swim();

            Console.ReadKey();
        }
    }
}