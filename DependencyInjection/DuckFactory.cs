using System.Collections.Generic;
using FirstTry.strategyPattern;
using Microsoft.Practices.Unity;

namespace DependencyInjection
{
    internal class DuckFactory
    {
        public List<Duck> CreateDucks()
        {
            return new List<Duck>
            {
                UnityContainerWrapper.Container.Resolve<Duck>("FakeDuck"),
                UnityContainerWrapper.Container.Resolve<Duck>("RubberDuck"),
                UnityContainerWrapper.Container.Resolve<Duck>("SimpleDuck"),
                UnityContainerWrapper.Container.Resolve<Duck>("WoodenDuck"),
            };
        }
    }
}