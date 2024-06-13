using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Math.Base
{
    /// <summary>
    /// Base class for a Shape.
    /// Uses .NET 7 Featured INumber defined generic type.
    /// </summary>
    public abstract class Shape
    {
        public double Area { get => CalculateArea(); }
        protected abstract double CalculateArea();
    }
}
