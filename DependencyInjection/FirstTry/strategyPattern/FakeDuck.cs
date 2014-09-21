using System;

namespace FirstTry.strategyPattern
{
    public class FakeDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I can't swim!");
        }

        public FakeDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyWithOutWings();
        }
    }
}