using System;

using FizzBuzz.Interfaces;

namespace FizzBuzz.Core.Strategies
{
    internal class FizzMapStrategy : IMapStrategy
    {
        public Tuple<int, string> Map(int input)
        {
            return input != 0 && input % 3 == 0 ? new Tuple<int, string>(input, "Fizz") : null;
        }
    }

    internal class BuzzMapStrategy : IMapStrategy
    {
        public Tuple<int, string> Map(int input)
        {
            return input != 0 && input % 5 == 0 ? new Tuple<int, string>(input, "Buzz") : null;
        }
    }

    internal class FizzBuzzMapStrategy : IMapStrategy
    {
        public Tuple<int, string> Map(int input)
        {
            return input != 0 && input % 3 == 0 && input % 5 == 0 ? new Tuple<int, string>(input, "FizzBuzz") : null;
        }
    }

    internal class DefaultMapStrategy : IMapStrategy
    {
        public Tuple<int, string> Map(int input)
        {
            return new Tuple<int, string>(input, input.ToString());
        }
    }
}
