using System;

namespace FirstTry.strategyPattern
{
    public class RubberDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public RubberDuck()
        {
            QuackBehavior = new Squeack();
            FlyBehavior = new FlyWithOutWings();
        }
    }
}