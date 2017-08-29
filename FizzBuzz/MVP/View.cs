using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace FizzBuzz.MVP
{
    internal class View : IView
    {
        public void PresnetResults(IEnumerable<string> results)
        {
            Contract.Requires(results != null);

            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
    }
}