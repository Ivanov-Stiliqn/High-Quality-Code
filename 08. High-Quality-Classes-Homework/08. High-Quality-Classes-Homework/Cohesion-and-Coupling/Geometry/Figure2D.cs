namespace CohesionAndCoupling.Geometry
{
    internal class Figure2D
    {
        protected const double FigureCenterX = 0;

        protected const double FigureCenterY = 0;

        internal Figure2D(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        internal double Height { get; private set; }

        internal double Width { get; private set; }

        internal double CalcDiagonalXY()
        {
            double distance = DimensionDistanceCalculater.CalcDistance2D(FigureCenterX, FigureCenterY, this.Width, this.Height);
            return distance;
        }
    }
}
