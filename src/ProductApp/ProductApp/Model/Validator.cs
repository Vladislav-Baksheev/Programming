namespace ProductApp.Model
{
    /// <summary>
    /// Содержит методы, обеспечивающие валидацию.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет строку на максимальную длину.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="max">Максимальное количество символов в строке.</param>
        /// <param name="propertyName">Название свойства, вызвавшего ошибку.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше максимальной длины.</exception>
        public static void AssertOnValue(string value, int max, string propertyName)
        {
            if(value.Length > max) 
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет, положительное ли число.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="propertyName">Название свойства, вызвавшего ошибку.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число отрицательное.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName) 
        { 
            if(value < 0)
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет строку на пустое значение.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Название свойства, вызвавшего ошибку.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если в строке ничего нет.</exception>
        public static void AssertOnEmptyValue(string value, string propertyName)
        {
            if(value == "")
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }
    }
}
