namespace FirstTry.strategyPattern
{
    public abstract class Duck
    {
        public abstract void Swim();

        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;

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
