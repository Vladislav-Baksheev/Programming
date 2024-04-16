namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит методы для проверки входных значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет входную строку на наличие только букв.
        /// </summary>
        /// <param name="value">Строка, которая должна быть проверена.</param>
        /// <param name="propertyName">Название свойства, в котором может возникнуть ошибка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка содержит не только буквы.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            string lowercaseWord = value.ToLower();
            for (int i = 0; i < lowercaseWord.Length; i++)
            {
                if(!((lowercaseWord[i] >= 'a') && (lowercaseWord[i] <= 'z')))
                {
                    throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
                }
            }
        }

        /// <summary>
        /// Проверяет входное число на положительное значение.
        /// </summary>
        /// <param name="value">Число, которое надо проверить.</param>
        /// <param name="propertyName">Название свойства, в котором может возникнуть ошибка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число меньше нуля.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if(value < 0)
            {
                throw new ArgumentException($"Отрицательное значение в поле: {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет входное число на положительное значение.
        /// </summary>
        /// <param name="value">Число, которое надо проверить.</param>
        /// <param name="propertyName">Название свойства, в котором может возникнуть ошибка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число меньше нуля.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if(value < 0)
            {
                throw new ArgumentException($"Отрицательное значение в поле: {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет, входит ли входное число в диапазон значений.
        /// </summary>
        /// <param name="value">Число, которое надо проверить.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Название свойства, в котором может возникнуть ошибка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если входное число находится вне диапазоне значений.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if((value < min) || (value > max))
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет, входит ли входное число в диапазон значений.
        /// </summary>
        /// <param name="value">Число, которое надо проверить.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="propertyName">Название свойства, в котором может возникнуть ошибка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если входное число находится вне диапазоне значений.</exception>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if((value < min) || (value > max))
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет, что значение меньшего числа не больше значения большего числа.
        /// </summary>
        /// <param name="low">Меньшее число.</param>
        /// <param name="big">Большее число.</param>
        /// <param name="propertyName">Название свойства, в котором может возникнуть ошибка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если меньшее число больше большего.</exception>
        public static void AssertOnBiggerValue(double low, double big, string propertyName)
        {
            if(low > big)
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }
    }
}
