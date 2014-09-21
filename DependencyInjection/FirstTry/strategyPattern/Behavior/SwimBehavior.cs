using System;

namespace FirstTry.strategyPattern
{
    public class SwimBehavior : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }
    }
}