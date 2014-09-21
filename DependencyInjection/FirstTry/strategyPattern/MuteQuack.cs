using System;

namespace FirstTry.strategyPattern
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("....");
        }
    }
}