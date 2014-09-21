using System;

namespace FirstTry.strategyPattern
{
    public class SimpleDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

        public SimpleDuck()
        {
            QuackBehavior = new Squeack();
            FlyBehavior = new FlyWithWings();
        }
    }
}