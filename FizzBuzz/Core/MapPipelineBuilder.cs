using System;
using System.Collections.Generic;
using System.Linq;

using FizzBuzz.Interfaces;

namespace FizzBuzz.Core
{

    public class MapPipelineBuilder : IMapPipelineBuilder
    {
        readonly List<IMapStrategy> mapStrategies = new List<IMapStrategy>();

        public void AddMapStrategy(IMapStrategy strategy)
        {
            mapStrategies.Add(strategy);
        }

        public Func<int, Tuple<int, string>> Build()
        {
            var pipeline = new Func<int, Tuple<int, string>>(
                i =>
                    {                        
                        return mapStrategies
                        .Select(s => s.Map(i))
                        .FirstOrDefault(x => x != null);
                    });

            return pipeline;
        }
    }
}