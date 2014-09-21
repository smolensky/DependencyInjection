using FirstTry.strategyPattern;
using Microsoft.Practices.Unity;

namespace DependencyInjection
{
    internal class UnityContainerWrapper
    {
        private static volatile object _lockObject = new object();

        private static UnityContainer _container;

        private UnityContainerWrapper()
        {
        }

        internal static UnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    lock (_lockObject)
                        if (_container == null)
                        {
                            return _container = GetContainer();
                        }
                }

                return _container;
            }
        }

        private static UnityContainer GetContainer()
        {
            var container = new UnityContainer();

            container
                .RegisterType<IQuackBehavior, MuteQuack>("MuteQuack")
                .RegisterType<IQuackBehavior, Squeack>("Squeack")

                .RegisterType<ISwimBehavior, SwimBehavior>("Swim")
                .RegisterType<ISwimBehavior, NoSwimBehavior>("NoSwim")

                .RegisterType<IFlyBehavior, FlyWithWings>("FlyWithWings")
                .RegisterType<IFlyBehavior, FlyWithoutWings>("FlyWithoutWings")

                .RegisterType<Duck>("FakeDuck",
                    new InjectionConstructor(container.Resolve<IFlyBehavior>("FlyWithoutWings"), container.Resolve<IQuackBehavior>("MuteQuack"), container.Resolve<ISwimBehavior>("NoSwim")))
                .RegisterType<Duck>("RubberDuck",
                    new InjectionConstructor(container.Resolve<IFlyBehavior>("FlyWithoutWings"), container.Resolve<IQuackBehavior>("Squeack"), container.Resolve<ISwimBehavior>("Swim")))
                .RegisterType<Duck>("SimpleDuck",
                    new InjectionConstructor(container.Resolve<IFlyBehavior>("FlyWithWings"), container.Resolve<IQuackBehavior>("Squeack"), container.Resolve<ISwimBehavior>("Swim")))
                .RegisterType<Duck>("WoodenDuck",
                    new InjectionConstructor(container.Resolve<IFlyBehavior>("FlyWithoutWings"), container.Resolve<IQuackBehavior>("MuteQuack"), container.Resolve<ISwimBehavior>("Swim")));

            return container;
        }
    }
}