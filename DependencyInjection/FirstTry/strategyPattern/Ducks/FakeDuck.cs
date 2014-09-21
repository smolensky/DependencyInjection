using System;

namespace FirstTry.strategyPattern.Ducks
{
    public class FakeDuck : Duck
    {
        public FakeDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            Console.WriteLine("I can't swim!");
        }

    }
}