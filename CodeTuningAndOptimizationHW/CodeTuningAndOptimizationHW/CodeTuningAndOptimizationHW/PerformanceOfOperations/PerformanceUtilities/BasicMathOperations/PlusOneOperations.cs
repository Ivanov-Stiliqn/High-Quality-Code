namespace PerformanceOfOperations.PerformanceUtilities.BasicMathOperations
{
    using static GlobalConstants;

    public class PlusOneOperations
    {
        public static void PlusOneIntValue()
        {
            int result = IntNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result += 1;
            }
        }

        public static void PlusOneLongValue()
        {
            long result = LongNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result += 1;
            }
        }

        public static void PlusOneFloatValue()
        {
            float result = FloatNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result += 1;
            }
        }

        public static void PlusOneDoubleValue()
        {
            double result = DoubleNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result += 1;
            }
        }

        public static void PlusOneDecimalValue()
        {
            decimal result = DecimalNumber;

            for (int i = 0; i < MaxOperations; i++)
            {
                result += 1;
            }
        }
    }
}