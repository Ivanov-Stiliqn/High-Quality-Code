namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public static class AddOperations
    {
        public static void AddIntValues()
        {
            int result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstInt + SecondInt;
            }
        }

        public static void AddLongValues()
        {
            long result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstLong + SecondLong;
            }
        }

        public static void AddFloatValues()
        {
            float result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstFloat + SecondFloat;
            }
        }

        public static void AddDoubleValues()
        {
            double result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDouble + SecondDouble;
            }
        }

        public static void AddDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDecimal + SecondDecimal;
            }
        }
    }
}