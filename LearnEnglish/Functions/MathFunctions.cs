using System;
using System.Threading;

namespace LearnEnglish.Functions
{
    public static class MathFunctions
    {
        // Thread-safe Random instance
        private static readonly ThreadLocal<Random> random = new (() => new Random());

        /// <summary>
        /// Generates a random integer within the specified range.
        /// </summary>
        /// <param name="min">The inclusive lower bound of the random number returned.</param>
        /// <param name="max">The exclusive upper bound of the random number returned. max must be greater than or equal to min.</param>
        /// <returns>A random integer that is greater than or equal to min, and less than max.</returns>
        public static int RandomNumber(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException(nameof(min), "min must be less than or equal to max.");
            }

            var randomInstance = random.Value ?? throw new InvalidOperationException("Random instance is null.");
            return randomInstance.Next(min, max);
        }
    }
}
