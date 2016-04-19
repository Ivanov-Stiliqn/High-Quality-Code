namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public static class IncrementPostfixOperations
    {
        public static void IncrementPostfixIntValue()
        {
            int result = IntNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result++;
            }
        }

        public static void IncrementPostfixLongValue()
        {
            long result = LongNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result++;
            }
        }

        public static void IncrementPostfixFloatValue()
        {
            float result = FloatNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result++;
            }
        }

        public static void IncrementPostfixDoubleValue()
        {
            double result = DoubleNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result++;
            }
        }

        public static void IncrementPostfixDecimalValue()
        {
            decimal result = DecimalNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result++;
            }
        }
    }
}