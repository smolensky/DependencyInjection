using System;

namespace FirstTry.strategyPattern.Ducks
{
    public class SimpleDuck : Duck
    {
        public SimpleDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

    }
}