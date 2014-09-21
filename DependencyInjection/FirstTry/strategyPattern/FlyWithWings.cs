using System;

namespace FirstTry.strategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("With wings!");
        }
    }
}