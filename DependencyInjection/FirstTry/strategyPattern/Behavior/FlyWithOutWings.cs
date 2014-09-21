using System;

namespace FirstTry.strategyPattern
{
    public class FlyWithOutWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}