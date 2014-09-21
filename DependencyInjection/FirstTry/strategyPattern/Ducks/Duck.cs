namespace FirstTry.strategyPattern
{
    public abstract class Duck
    {
        public abstract void Swim();

        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }
}
