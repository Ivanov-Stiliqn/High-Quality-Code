namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Geometry;

    internal class UtilsExamples
    {
        private static void Main()
        {
            Console.WriteLine(FileNameSplitter.GetFileExtension("example"));
            Console.WriteLine(FileNameSplitter.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameSplitter.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameSplitter.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameSplitter.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameSplitter.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", DimensionDistanceCalculater.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", DimensionDistanceCalculater.CalcDistance3D(5, 2, -1, 3, -6, 4));
 
            var figure3D = new Figure3D(4, 3, 5);
            Console.WriteLine("Volume = {0:f2}", figure3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure3D.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure3D.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure3D.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure3D.CalcDiagonalYZ());
        }
    }
}