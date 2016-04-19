namespace PerformanceOfOperations
{
    using System;
    using System.Diagnostics;
    using static PerformanceUtilities.BasicMathOperations.AddOperations;
    using static PerformanceUtilities.BasicMathOperations.DivideOperations;
    using static PerformanceUtilities.BasicMathOperations.IncrementPostfixOperations;
    using static PerformanceUtilities.BasicMathOperations.IncrementPrefixOperations;
    using static PerformanceUtilities.BasicMathOperations.MultiplyOperations;
    using static PerformanceUtilities.BasicMathOperations.PlusOneOperations;
    using static PerformanceUtilities.BasicMathOperations.SubtractOperations;
    using static PerformanceUtilities.ComplexMathOperations.SquareRootOperations;
    using static PerformanceUtilities.ComplexMathOperations.NaturalLogarithmOperations;
    using static PerformanceUtilities.ComplexMathOperations.SineOperations;

    public class PerformanceMain
    {
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            // Add operation Int
            stopwatch.Start();
            AddIntValues();
            stopwatch.Stop();
            Console.WriteLine("Add operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Add operation Long
            stopwatch.Start();
            AddLongValues();
            stopwatch.Stop();
            Console.WriteLine("Add operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Add operation Float
            stopwatch.Start();
            AddFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Add operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Add operation Double
            stopwatch.Start();
            AddDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Add operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Add operation Decimal
            stopwatch.Start();
            AddDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Add operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // Subtract operation Int
            stopwatch.Start();
            SubtractIntValues();
            stopwatch.Stop();
            Console.WriteLine("Subtract operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Subtract operation Long
            stopwatch.Start();
            SubtractLongValues();
            stopwatch.Stop();
            Console.WriteLine("Subtract operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Subtract operation Float
            stopwatch.Start();
            SubtractFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Subtract operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Subtract operation Double
            stopwatch.Start();
            SubtractDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Subtract operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Subtract operation Decimal
            stopwatch.Start();
            SubtractDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Subtract operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // IncrementPrefix operation Int
            stopwatch.Start();
            IncrementPrefixIntValue();
            stopwatch.Stop();
            Console.WriteLine("Increment prefix operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // IncrementPrefix operation Long
            stopwatch.Start();
            IncrementPrefixLongValue();
            stopwatch.Stop();
            Console.WriteLine("Increment prefix operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // IncrementPrefix operation Float
            stopwatch.Start();
            IncrementPrefixFloatValue();
            stopwatch.Stop();
            Console.WriteLine("Increment prefix operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // IncrementPrefix operation Double
            stopwatch.Start();
            IncrementPrefixDoubleValue();
            stopwatch.Stop();
            Console.WriteLine("Increment prefix operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // IncrementPrefix operation Decimal
            stopwatch.Start();
            IncrementPrefixDecimalValue();
            stopwatch.Stop();
            Console.WriteLine("Increment prefix operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // IncrementPostfix operation Int
            stopwatch.Start();
            IncrementPostfixIntValue();
            stopwatch.Stop();
            Console.WriteLine("Increment postfix operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // IncrementPostfix operation Long
            stopwatch.Start();
            IncrementPostfixLongValue();
            stopwatch.Stop();
            Console.WriteLine("Increment postfix operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            //IncrementPostfix operation Float
            stopwatch.Start();
            IncrementPostfixFloatValue();
            stopwatch.Stop();
            Console.WriteLine("Increment postfix operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // IncrementPostfix operation Double
            stopwatch.Start();
            IncrementPostfixDoubleValue();
            stopwatch.Stop();
            Console.WriteLine("Increment postfix operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            //IncrementPostfix operation Decimal
            stopwatch.Start();
            IncrementPostfixDecimalValue();
            stopwatch.Stop();
            Console.WriteLine("Increment postfix operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // PlusOne operation Int
            stopwatch.Start();
            PlusOneIntValue();
            stopwatch.Stop();
            Console.WriteLine("Plus one operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // PlusOne operation Long
            stopwatch.Start();
            PlusOneLongValue();
            stopwatch.Stop();
            Console.WriteLine("Plus one operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // PlusOne operation Float
            stopwatch.Start();
            PlusOneFloatValue();
            stopwatch.Stop();
            Console.WriteLine("Plus one operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // PlusOne operation Double
            stopwatch.Start();
            PlusOneDoubleValue();
            stopwatch.Stop();
            Console.WriteLine("Plus one operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // PlusOne operation Decimal
            stopwatch.Start();
            PlusOneDecimalValue();
            stopwatch.Stop();
            Console.WriteLine("Plus one operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // Multiply operation Int
            stopwatch.Start();
            MultiplyIntValues();
            stopwatch.Stop();
            Console.WriteLine("Multiply operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Multiply operation Long
            stopwatch.Start();
            MultiplyLongValues();
            stopwatch.Stop();
            Console.WriteLine("Multiply operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Multiply operation Float
            stopwatch.Start();
            MultiplyFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Multiply operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Multiply operation Double
            stopwatch.Start();
            MultiplyDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Multiply operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Multiply operation Decimal
            stopwatch.Start();
            MultiplyDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Multiply operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // Divide operation Int
            stopwatch.Start();
            DivideIntValues();
            stopwatch.Stop();
            Console.WriteLine("Divide operation for Int: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Divide operation Long
            stopwatch.Start();
            DivideLongValues();
            stopwatch.Stop();
            Console.WriteLine("Divide operation for Long: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Divide operation Float
            stopwatch.Start();
            DivideFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Divide operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Divide operation Double
            stopwatch.Start();
            DivideDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Divide operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Divide operation Decimal
            stopwatch.Start();
            DivideDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Divide operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // Square root operation Float
            stopwatch.Start();
            SquareRootFloat();
            stopwatch.Stop();
            Console.WriteLine("Sqrt operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Square root operation Double
            stopwatch.Start();
            SquareRootDouble();
            stopwatch.Stop();
            Console.WriteLine("Sqrt operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Square root operation Decimal
            stopwatch.Start();
            SquareRootDecimal();
            stopwatch.Stop();
            Console.WriteLine("Sqrt operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // Natural logarithm operation Float
            stopwatch.Start();
            NaturalLogarithmFloat();
            stopwatch.Stop();
            Console.WriteLine("Natural logarithm operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Natural logarithm operation Double
            stopwatch.Start();
            NaturalLogarithmDouble();
            stopwatch.Stop();
            Console.WriteLine("Natural logarithm operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Natural logarithm operation Decimal
            stopwatch.Start();
            NaturalLogarithmDecimal();
            stopwatch.Stop();
            Console.WriteLine("Natural logarithm operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();

            // Sine operation Float
            stopwatch.Start();
            SineFloat();
            stopwatch.Stop();
            Console.WriteLine("Sine operation for Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Sine operation Double
            stopwatch.Start();
            SineDouble();
            stopwatch.Stop();
            Console.WriteLine("Sine operation for Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            // Sine operation Decimal
            stopwatch.Start();
            SineDecimal();
            stopwatch.Stop();
            Console.WriteLine("Sine operation for Decimal: " + stopwatch.Elapsed + Environment.NewLine);
            stopwatch.Reset();
        }
    }
}