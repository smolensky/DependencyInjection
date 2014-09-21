using System;

namespace FirstTry.strategyPattern.Ducks
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

    }
}