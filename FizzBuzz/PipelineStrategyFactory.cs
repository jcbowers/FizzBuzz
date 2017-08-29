using System;

using FizzBuzz.Core;
using FizzBuzz.Interfaces;

using Microsoft.Practices.Unity;

namespace FizzBuzz
{
    public class PipelineStrategyFactory
    {
        private readonly UnityContainer _container;

        private readonly string _strategy;

        public PipelineStrategyFactory(string strategy, UnityContainer container)
        {
            _container = container;
            _strategy = strategy?.ToLower();
        }

        public IPipelineSequenceOrchastrator Make()
        {
            if (_strategy == "fp")
            {
                return _container.Resolve<FunctionalPipelineSequenceOrchastrator>();
            }

            return _container.Resolve<PipelineSequenceOrchastrator>();
        }
    }
}
