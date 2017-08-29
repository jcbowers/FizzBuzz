using System.Collections.Generic;

namespace FizzBuzz.MVP
{
    internal interface IView
    {
        void PresnetResults(IEnumerable<string> results);
    }
}