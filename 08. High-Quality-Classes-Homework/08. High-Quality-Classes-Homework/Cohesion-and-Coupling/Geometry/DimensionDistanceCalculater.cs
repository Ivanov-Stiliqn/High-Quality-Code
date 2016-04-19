namespace CohesionAndCoupling.Geometry
{
    using System;

    internal static class DimensionDistanceCalculater
    {
        internal static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double deltaX = (x2 - x1) * (x2 - x1);
            double deltaY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(deltaX + deltaY);
            return distance;
        }

        internal static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double deltaX = (x2 - x1) * (x2 - x1);
            double deltaY = (y2 - y1) * (y2 - y1);
            double deltaZ = (z2 - z1) * (z2 - z1);
            double distance = Math.Sqrt(deltaX + deltaY + deltaZ);
            return distance;
        }
    }
}
