using System;

namespace FizzBuzz.Interfaces
{
    public interface IMapPipelineBuilder
    {
        void AddMapStrategy(IMapStrategy strategy);

        Func<int, Tuple<int, string>> Build();
    }
}