using System;

namespace FirstTry.strategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

    }
}