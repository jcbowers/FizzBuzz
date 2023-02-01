using System;

using FizzBuzz.Interfaces;

namespace FizzBuzz.Core
{
    public class FunctionalPipelineSequenceOrchastrator : IPipelineSequenceOrchastrator
    {
        public Func<int, Tuple<int, string>> GetPipelineFunc()
        {
            return new Func<int, Tuple<int, string>>(GetFizz)
                    .TryTo(GetBuzz)
                    .TryTo(GetFizzBuzz)
                    .TryTo(GetDefault);
        }

        private static Tuple<int, string> GetFizzBuzz(int i) => i != 0 && i % 3 == 0 && i % 5 == 0 ? new Tuple<int, string>(i, "Fizzbuzz") : null;

        private static Tuple<int, string> GetFizz(int i) => i != 0 && i % 3 == 0 ? new Tuple<int, string>(i, "Fizz") : null;

        private static Tuple<int, string> GetBuzz(int i) => i != 0 && i % 5 == 0 ? new Tuple<int, string>(i, "buzz") : null;

        private static Tuple<int, string> GetDefault(int i) => new Tuple<int, string>(i, i.ToString());
    }
}