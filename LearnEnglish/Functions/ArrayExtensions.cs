namespace LearnEnglish.Functions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Sprawdza, czy tablica jest pusta bądź jej długość wynosi 0.
        /// </summary>
        /// <param name="array">Tablica do testowania.</param>
        /// <returns>True, jeśli tablica spełnia warunki. False, jeśli nie spełnia.</returns>
        public static bool IsNullOrEmpty(this Array array)
        {
            return array is null || array.Length == 0;
        }
    }
}
