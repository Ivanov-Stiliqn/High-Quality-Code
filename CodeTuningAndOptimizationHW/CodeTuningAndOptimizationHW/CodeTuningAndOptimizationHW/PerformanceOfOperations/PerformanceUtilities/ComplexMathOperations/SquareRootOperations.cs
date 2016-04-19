namespace PerformanceOfOperations.PerformanceUtilities.ComplexMathOperations
{
    using System;
    using static GlobalConstants;

    public static class SquareRootOperations
    {
        public static void SquareRootFloat()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Sqrt(FloatNumber);
            }
        }

        public static void SquareRootDouble()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Sqrt(DoubleNumber);
            }
        }

        public static void SquareRootDecimal()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Sqrt((double)DecimalNumber);
            }
        }
    }
}