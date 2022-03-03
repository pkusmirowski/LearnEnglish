namespace LearnEnglish.Functions
{
    public static class MathFunctions
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new();
            return random.Next(min, max);
        }
    }
}
