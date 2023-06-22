namespace LearnEnglish.Functions
{
    public static class MathFunctions
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Generuje losową liczbę całkowitą z podanego zakresu.
        /// </summary>
        /// <param name="min">Najmniejsza wartość zakresu (włącznie).</param>
        /// <param name="max">Największa wartość zakresu (wyłącznie).</param>
        /// <returns>Losowa liczba całkowita z podanego zakresu.</returns>
        public static int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
