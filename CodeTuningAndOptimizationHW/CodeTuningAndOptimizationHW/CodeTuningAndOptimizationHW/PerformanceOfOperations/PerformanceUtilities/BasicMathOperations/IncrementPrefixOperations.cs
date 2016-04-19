namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public static class IncrementPrefixOperations
    {
        public static void IncrementPrefixIntValue()
        {
            int result = IntNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                ++result;
            }
        }

        public static void IncrementPrefixLongValue()
        {
            long result = LongNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                ++result;
            }
        }

        public static void IncrementPrefixFloatValue()
        {
            float result = FloatNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                ++result;
            }
        }

        public static void IncrementPrefixDoubleValue()
        {
            double result = DoubleNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                ++result;
            }
        }

        public static void IncrementPrefixDecimalValue()
        {
            decimal result = DecimalNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                ++result;
            }
        }
    }
}