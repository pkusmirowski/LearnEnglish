using System;

namespace SicariosSA.Functions
{
    static public class MathFunctions
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new();
            return random.Next(min, max);
        }
    }
}
