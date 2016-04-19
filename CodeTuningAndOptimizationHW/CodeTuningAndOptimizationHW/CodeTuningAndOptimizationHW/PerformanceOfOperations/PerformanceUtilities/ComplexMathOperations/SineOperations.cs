namespace PerformanceOfOperations.PerformanceUtilities.ComplexMathOperations
{
    using System;
    using static GlobalConstants;

    public static class SineOperations
    {
        public static void SineFloat()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Sin(FloatNumber);
            }
        }

        public static void SineDouble()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Sin(DoubleNumber);
            }
        }

        public static void SineDecimal()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Sin((double)DecimalNumber);
            }
        }
    }
}