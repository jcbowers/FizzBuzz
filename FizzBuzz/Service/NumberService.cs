using System.Collections.Generic;
using System.Linq;

using FizzBuzz.Interfaces;

namespace FizzBuzz.Service
{

    public class NumberService : INumberService
    {
        public IEnumerable<int> GetNumbers()
        {
            return Enumerable.Range(0, 101);
        }
    }
}
