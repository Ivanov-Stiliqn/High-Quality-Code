namespace Abstraction
{
    using System;

    internal class Rectangle : Figure
    {
        private double width;

        private double height;

        internal Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        internal double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width", "Width must be possitve");
                }

                this.width = value;
            }
        }

        internal double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height", "Height must be possitve");
                }

                this.height = value;
            }
        }

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        internal override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}