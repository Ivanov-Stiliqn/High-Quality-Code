namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public static class MultiplyOperations
    {
        public static void MultiplyIntValues()
        {
            int result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstInt * SecondInt;
            }
        }

        public static void MultiplyLongValues()
        {
            long result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstLong * SecondLong;
            }
        }

        public static void MultiplyFloatValues()
        {
            float result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstFloat * SecondFloat;
            }
        }

        public static void MultiplyDoubleValues()
        {
            double result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDouble * SecondDouble;
            }
        }

        public static void MultiplyDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDecimal * SecondDecimal;
            }
        }
    }
}