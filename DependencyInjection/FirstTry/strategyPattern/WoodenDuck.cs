using System;

namespace FirstTry.strategyPattern
{
    public class WoodenDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public WoodenDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyWithOutWings();
        }
    }
}