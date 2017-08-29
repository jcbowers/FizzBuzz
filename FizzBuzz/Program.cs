using System;
using System.Linq;

using FizzBuzz.Core;
using FizzBuzz.Interfaces;
using FizzBuzz.MVP;

using Microsoft.Practices.Unity;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var container = new UnityContainer())
            {
                UnityModule.RegisterTypes(container);

                var factory = new PipelineOrchastratorFactory(args.FirstOrDefault(), container);

                container.RegisterInstance(typeof(IPipelineSequenceOrchastrator), factory.Make());

                var presenter = container.Resolve<IPresenter>();

                presenter.Run();
            }

            Console.ReadKey();
        }
    }
}
