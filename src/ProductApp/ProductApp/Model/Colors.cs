namespace ProductApp.Model
{
    /// <summary>
    /// Хранит цвета для валидации.
    /// </summary>
    public static class Colors
    {
        /// <summary>
        /// Цвет, если прошло проверку.
        /// </summary>
        public static Color NormalColor = Color.White;

        /// <summary>
        /// Цвет, если появилась ошибка.
        /// </summary>
        public static Color BadColor = Color.LightPink;
    }
}
