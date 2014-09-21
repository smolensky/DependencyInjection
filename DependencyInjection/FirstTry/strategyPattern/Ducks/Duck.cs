using System;

namespace FirstTry.strategyPattern
{
    public class Duck
    {
        private readonly IFlyBehavior _flyBehavior;
        private readonly IQuackBehavior _quackBehavior;
        private readonly ISwimBehavior _swimBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimBehavior swimBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _swimBehavior = swimBehavior;

            Console.WriteLine("I'm created!");
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void PerformSwim()
        {
            _swimBehavior.Swim();
        }
    }
}
