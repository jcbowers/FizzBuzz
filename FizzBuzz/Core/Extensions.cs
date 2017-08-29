using System;

namespace FizzBuzz.Core
{
    internal static class Extensions
    {
        internal static Func<T1, T2> TryTo<T1, T2>(this Func<T1, T2> func, Func<T1, T2> continuation)
            where T2: class
        {
            return x => func(x) ?? continuation(x);
        }
    }
}
