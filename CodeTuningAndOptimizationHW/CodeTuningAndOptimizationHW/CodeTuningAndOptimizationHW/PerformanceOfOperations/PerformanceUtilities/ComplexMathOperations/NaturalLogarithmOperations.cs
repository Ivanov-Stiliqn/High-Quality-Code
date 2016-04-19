namespace PerformanceOfOperations.PerformanceUtilities.ComplexMathOperations
{
    using System;
    using static GlobalConstants;

    public class NaturalLogarithmOperations
    {
        public static void NaturalLogarithmFloat()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Log(FloatNumber, Math.PI);
            }
        }

        public static void NaturalLogarithmDouble()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Log(DoubleNumber, Math.PI);
            }
        }

        public static void NaturalLogarithmDecimal()
        {
            for (int i = 0; i < MaxOperations; i++)
            {
                Math.Log((double)DecimalNumber, Math.PI);
            }
        }
    }
}