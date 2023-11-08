using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет функционал для проверки входных значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет переданную строку на кол-во символов.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя метода.</param>
        /// <exception cref="ArgumentException">Если строка оказалась длиннее чем заданное максимальное значения длины.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length > maxLength) 
            {
                throw new ArgumentException($"Строка превышает максимальную длину: " + $"{maxLength} в поле {propertyName}.");
            }
        }
        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя метода.</param>
        /// <exception cref="ArgumentException">Если число выходит за границы диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value > max | value < min)
            {
                throw new ArgumentException($"Выход за диапазон значений в поле: {propertyName}");
            }
        }

        public static void AssertCountSymbols(int value, int countSymbols, string propertyName)
        {
            if (value.ToString().Length != countSymbols)
            {
                throw new ArgumentException($"Некорректная длина поле {propertyName}." +
                    $" Необходимая длина = {countSymbols}");
            }
        }
    }
}
