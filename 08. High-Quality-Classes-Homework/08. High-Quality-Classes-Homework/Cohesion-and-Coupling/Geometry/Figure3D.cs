namespace CohesionAndCoupling.Geometry
{
    internal class Figure3D : Figure2D
    {
        protected const double FigureCenterZ = 0;

        internal Figure3D(double height, double width, double depth)
            : base(height, width)
        {
            this.Depth = depth;
        }

        internal double Depth { get; set; }

        internal double CalcDiagonalXZ()
        {
            double distance = DimensionDistanceCalculater.CalcDistance2D(FigureCenterX, FigureCenterZ, this.Width, this.Depth);
            return distance;
        }

        internal double CalcDiagonalYZ()
        {
            double distance = DimensionDistanceCalculater.CalcDistance2D(FigureCenterY, FigureCenterZ, this.Height, this.Depth);
            return distance;
        }

        internal double CalcDiagonalXYZ()
        {
            double distance = DimensionDistanceCalculater.CalcDistance3D(
                FigureCenterX, FigureCenterY, FigureCenterZ, this.Width, this.Height, this.Depth);
            return distance;
        }

        internal double CalcVolume()
        {
            double volume = this.Height * this.Width * this.Depth;
            return volume;
        }
    }
}
