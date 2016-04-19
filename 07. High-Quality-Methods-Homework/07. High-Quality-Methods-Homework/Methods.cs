using System;
using Methods.Exceptions;

namespace Methods
{
    public static class Methods
    {
        /// <summary>
        /// Calculates the area of a triangle by the heron's formula.
        /// </summary>
        /// <param name="a">sideA</param>
        /// <param name="b">sideB</param>
        /// <param name="c">sideC</param>
        /// <returns>Returns the area of the given triangle</returns>
        /// <exception cref="InvalidTriangleSidesException">All sides of the triangle should be positive</exception>
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidTriangleSidesException("Sides should be positive.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        /// <summary>
        /// Returns the english representation of the given digit.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="InvalidDigitException">The input digit should be valid.</exception>
        public static string ShowDigitAsLetters(int number)
        {
            switch (number)
            {
                case 0: 
                    return "zero";
                case 1: 
                    return "one";
                case 2: 
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9: 
                    return "nine";
                default:
                    throw new InvalidDigitException("Invalid number!");
            }
        }
        
        /// <summary>
        /// Finds the max element in collection of integers.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns>Returns the max element.</returns>
        /// <exception cref="NullReferenceException">The input collection must contain at least one element.</exception>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("Empty collection");
            }

            int max = elements[0];
            for (int current = 1; current < elements.Length; current++)
            {
                if (elements[current] > max)
                {
                    max = elements[current];
                }
            }

            return max;
        }

        /// <summary>
        /// Prints the given number in a wanted format.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="format"></param>
        public static void PrintNumberFormat(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        /// <summary>
        /// Calculates the distance between two lines.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double CalcDistance(
            double x1, 
            double y1,
            double x2, 
            double y2)
        {
            double deltaX = (x2 - x1) * (x2 - x1);
            double deltaY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(deltaX + deltaY);
            return distance;
        }

        /// <summary>
        /// Checks if two lines are horizontal, vertical or neither.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="isHorizontal"></param>
        /// <param name="isVertical"></param>
        public static void CheckLinesPosition(
            double x1,
            double y1,
            double x2,
            double y2,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = Equals(y1, y2);
            isVertical = Equals(x1, x2);
        }
    }
}
