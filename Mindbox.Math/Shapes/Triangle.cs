using Mindbox.Math.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Math.Shapes
{
    /// <summary>
    /// Computes Triangle figure by Gerone's formula
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Side A
        /// </summary>
        private double A;

        /// <summary>
        /// Side B
        /// </summary>
        private double B;

        /// <summary>
        /// Side C
        /// </summary>
        private double C;

        /// <summary>
        /// Is triangle right
        /// </summary>
        public bool IsRight { get; private set; }

        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="sideA">A side</param>
        /// <param name="sideB">B side</param>
        /// <param name="sideC">C side</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0) throw new ArgumentException("Sides must be positive number");

            A = sideA;
            B = sideB;
            C = sideC;

            var pA = System.Math.Pow(A, 2);
            var pB = System.Math.Pow(B, 2);
            var pC = System.Math.Pow(C, 2);

            if ((pA + pB == pC) 
                || (pA + pC == pB) 
                || (pC + pB == pA))
            {
                IsRight = true;
            }
        }

        protected override double CalculateArea()
        {
            var _half = SemiPerimeter();

            return System.Math.Sqrt(_half * ((_half - A) * (_half - B) * (_half - C)));
        }


        /// <summary>
        /// Computes SemiPerimeter.
        /// </summary>
        /// <returns>SemiPerimeter of a triangle</returns>
        private double SemiPerimeter()
        {
            return (A + B + C) * 0.5;
        }
    }
}
