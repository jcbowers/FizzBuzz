using System;
using System.Collections.Generic;
using System.Linq;

using FizzBuzz.Interfaces;

namespace FizzBuzz.Core.Strategies
{
    public class PipelineExecutionStrategy : IPipelineExecutionStrategy
    {
        private readonly IPipelineSequenceOrchastrator pipelineSequenceOrchastrator;

        public PipelineExecutionStrategy(IPipelineSequenceOrchastrator pipelineSequenceOrchastrator)
        {
            this.pipelineSequenceOrchastrator = pipelineSequenceOrchastrator;
        }

        public IEnumerable<Tuple<int, string>> RunChain(IEnumerable<int> inputs)
        {
            var pipeline = pipelineSequenceOrchastrator.GetPipelineFunc();

            return inputs.Select(pipeline);
        }
    }
}
