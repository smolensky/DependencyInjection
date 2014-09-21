using System;

namespace FirstTry.strategyPattern
{
    public class NoSwimBehavior : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim!");
        }
    }
}