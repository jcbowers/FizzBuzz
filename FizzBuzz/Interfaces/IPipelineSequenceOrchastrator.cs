using System;

namespace FizzBuzz.Interfaces
{
    public interface IPipelineSequenceOrchastrator
    {
        Func<int, Tuple<int, string>> GetPipelineFunc();
    }
}