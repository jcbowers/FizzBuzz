using System;
using System.Collections.Generic;

namespace FizzBuzz.Interfaces
{
    public interface IMapStrategy
    {
        Tuple<int, string> Map(int input);
    }

    public interface IPipelineExecutionStrategy
    {
        IEnumerable<Tuple<int, string>> RunChain(IEnumerable<int> inputs);
    }
}
