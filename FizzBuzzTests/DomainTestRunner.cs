using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    public abstract class DomainTestRunner
    {
        private readonly DomainTests _domainTests;

        protected DomainTestRunner(DomainTests domainTests)
        {
            _domainTests = domainTests;
        }

        [TestMethod]
        public void ShowFizz()
        {
            _domainTests.TestFizz();
        }

        [TestMethod]
        public void ShowBuzz()
        {
            _domainTests.TestBuzz();
        }

        [TestMethod]
        public void ShowFizzBuzz()
        {
            _domainTests.TestFizzBuzz();
        }
    }
}
