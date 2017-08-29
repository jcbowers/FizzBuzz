using System;

using FizzBuzz.Core.Strategies;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Core
{

    public class PipelineSequenceOrchastrator : IPipelineSequenceOrchastrator
    {
        private readonly IMapPipelineBuilder pipelineBuilder;

        public PipelineSequenceOrchastrator(IMapPipelineBuilder pipelineBuilder)
        {
            this.pipelineBuilder = pipelineBuilder;
        }

        public Func<int, Tuple<int, string>> GetPipelineFunc()
        {
            pipelineBuilder.AddMapStrategy(new FizzBuzzMapStrategy());
            pipelineBuilder.AddMapStrategy(new FizzMapStrategy());
            pipelineBuilder.AddMapStrategy(new BuzzMapStrategy());
            pipelineBuilder.AddMapStrategy(new DefaultMapStrategy());

            return pipelineBuilder.Build();
        }
    }
}