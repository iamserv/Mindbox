using Mindbox.Math.Base;

namespace Mindbox.Math.Shapes
{
    /// <summary>
    /// Circle shape.
    /// </summary>
    public class Circle : Shape
    {
        private double _radius;


        /// <summary>
        /// Creates circle with given numbers
        /// </summary>
        /// <param name="radius">Positive number</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Radius must be positive number");

            _radius = radius;
        }

        /// <summary>
        /// Calculates circle area
        /// </summary>
        protected override double CalculateArea()
        {
            return System.Math.PI * (System.Math.Pow(_radius, 2));
        }
    }
}
 