using System;
using System.Collections.Generic;
using System.Diagnostics;
using FirstTry.strategyPattern;
using FirstTry.strategyPattern.Ducks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace DependencyInjection
{
    internal class Program
    {
        internal static UnityContainer _container;

        static void Main()
        {
            _container = new UnityContainer();
            RegisterDependencies();

            var ducks = new DuckFactory().CreateDucks();

            for (int i = 0; i < ducks.Count; i++)
            {
                DoDuckThings(ducks[i], i+1);
            }

            Console.ReadKey();
        }

        private static void RegisterDependencies()
        {

            _container
                .RegisterType<IQuackBehavior, MuteQuack>("MuteQuack")
                .RegisterType<IQuackBehavior, Squeack>("Squeack")

                .RegisterType<IFlyBehavior, FlyWithWings>("FlyWithWings")
                .RegisterType<IFlyBehavior, FlyWithoutWings>("FlyWithoutWings")

                .RegisterType<FakeDuck>(
                    new InjectionConstructor(_container.Resolve<IFlyBehavior>("FlyWithoutWings"),
                        _container.Resolve<IQuackBehavior>("MuteQuack")))
                .RegisterType<RubberDuck>(
                    new InjectionConstructor(_container.Resolve<IFlyBehavior>("FlyWithoutWings"),
                        _container.Resolve<IQuackBehavior>("Squeack")))
                .RegisterType<SimpleDuck>(
                    new InjectionConstructor(_container.Resolve<IFlyBehavior>("FlyWithWings"),
                        _container.Resolve<IQuackBehavior>("Squeack")))
                .RegisterType<WoodenDuck>(
                    new InjectionConstructor(_container.Resolve<IFlyBehavior>("FlyWithoutWings"),
                        _container.Resolve<IQuackBehavior>("MuteQuack")));
        }

        private static void DoDuckThings(Duck duck, int number)
        {
            Console.WriteLine(number + " duck");

            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();

            Console.WriteLine("\n");
        }
    }

    internal class DuckFactory
    {
        public List<Duck> CreateDucks()
        {
            return new List<Duck>
            {
                Program._container.Resolve<FakeDuck>(),
                Program._container.Resolve<RubberDuck>(),
                Program._container.Resolve<SimpleDuck>(),
                Program._container.Resolve<WoodenDuck>(),
            };
        }
    }
}
