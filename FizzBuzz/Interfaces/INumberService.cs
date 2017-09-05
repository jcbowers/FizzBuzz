using System.Collections.Generic;

namespace FizzBuzz.Interfaces
{
    public interface INumberService
    {
        IEnumerable<int> GetNumbers();
    }
}
