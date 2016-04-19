namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public static class SubtractOperations
    {
        public static void SubtractIntValues()
        {
            int result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstInt - SecondInt;
            }
        }

        public static void SubtractLongValues()
        {
            long result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstLong - SecondLong;
            }
        }

        public static void SubtractFloatValues()
        {
            float result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstFloat - SecondFloat;
            }
        }

        public static void SubtractDoubleValues()
        {
            double result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDouble - SecondDouble;
            }
        }

        public static void SubtractDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDecimal - SecondDecimal;
            }
        }
    }
}