using FizzBuzz.Core;
using FizzBuzz.Core.Strategies;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class ObjectOrientedUnitTests : DomainTestRunner
    {
        public ObjectOrientedUnitTests() : base(new DomainTests(new PipelineExecutionStrategy(new PipelineSequenceOrchastrator(new MapPipelineBuilder()))))
        {            
        }
    }

    [TestClass]
    public class FunctionalUnitTests : DomainTestRunner
    {
        public FunctionalUnitTests() : base(new DomainTests(new PipelineExecutionStrategy(new FunctionalPipelineSequenceOrchastrator())))
        {
        }
    }
}
