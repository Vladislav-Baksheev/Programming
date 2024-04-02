using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class AppColor
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static readonly Color ErrorBackColor = Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static readonly Color NormalBackColor = Color.White;

        /// <summary>
        /// Цвет непересекающихся фигур.
        /// </summary>
        public static readonly Color NotCollision = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static readonly Color Collision = Color.FromArgb(127, 255, 127, 127);
    }
}
