namespace Abstraction
{
    using System;

    internal class Circle : Figure
    {
        private double radius;

        internal Circle(double radius)
        {
            this.Radius = radius;
        }

        internal double Radius 
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("radius", "Radius must be possitve");
                }

                this.radius = value;
            }
        }

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        internal override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}