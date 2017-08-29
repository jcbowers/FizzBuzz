using System.Linq;

using FizzBuzz.Core.Strategies;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    public class DomainTests
    {
        private readonly PipelineExecutionStrategy _executionStrategy;

        public DomainTests(PipelineExecutionStrategy executionStrategy)
        {
            _executionStrategy = executionStrategy;
        }

        public void TestFizz()
        {
            var values = new [] { -3, 0, 2, 3, 7 };

            // act
            var result = _executionStrategy.RunChain(values).ToArray();

            // assert
            Assert.AreEqual(2, result.Count(r => r.Item2.ToLower() == "fizz"));
            Assert.AreEqual(0, result.Count(r => r.Item2.ToLower() == "buzz"));
            Assert.AreEqual(0, result.Count(r => r.Item2.ToLower() == "fizzbuzz"));
        }

        public void TestBuzz()
        {
            var values = new [] { -5, -2, 0, 2, 4, 5, 8 };

            // act
            var result = _executionStrategy.RunChain(values).ToArray();

            // assert
            Assert.AreEqual(2, result.Count(r => r.Item2.ToLower() == "buzz"));
            Assert.AreEqual(0, result.Count(r => r.Item2.ToLower() == "fizz"));
            Assert.AreEqual(0, result.Count(r => r.Item2.ToLower() == "fizzbuzz"));
        }

        public void TestFizzBuzz()
        {
            var values = new [] { -15, -2, 0, 2, 4, 15, 16 };

            // act
            var result = _executionStrategy.RunChain(values).ToArray();

            // assert
            Assert.AreEqual(2, result.Count(r => r.Item2.ToLower() == "fizzbuzz"));
            Assert.AreEqual(0, result.Count(r => r.Item2.ToLower() == "fizz"));
            Assert.AreEqual(0, result.Count(r => r.Item2.ToLower() == "buzz"));
        }
    }
}
