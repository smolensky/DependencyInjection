using System;

namespace FirstTry.strategyPattern
{
    public class FlyWithoutWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}