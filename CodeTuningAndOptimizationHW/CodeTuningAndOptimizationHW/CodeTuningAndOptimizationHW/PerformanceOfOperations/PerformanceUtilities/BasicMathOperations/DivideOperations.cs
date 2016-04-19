namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public static class DivideOperations
    {
        public static void DivideIntValues()
        {
            int result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstInt / SecondInt;
            }
        }

        public static void DivideLongValues()
        {
            long result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstLong / SecondLong;
            }
        }

        public static void DivideFloatValues()
        {
            float result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstFloat / SecondFloat;
            }
        }

        public static void DivideDoubleValues()
        {
            double result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDouble / SecondDouble;
            }
        }

        public static void DivideDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MaxOperations; i++)
            {
                result = FirstDecimal / SecondDecimal;
            }
        }
    }
}