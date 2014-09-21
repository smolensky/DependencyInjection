using System;

namespace FirstTry.strategyPattern
{
    public class Squeack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Pew! Pew! Pew!!!");
        }
    }
}