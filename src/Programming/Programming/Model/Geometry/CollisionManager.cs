using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < rectangle1.Width / 2 + rectangle2.Width / 2 &&
            Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < rectangle1.Length / 2 + rectangle2.Length / 2)
            {
                return true;
            }
            return false;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}
