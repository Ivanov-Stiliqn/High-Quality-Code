using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MultiplyingArrays
    {
        static void Main(string[] args)
        {
            var firstArray = new double[,]
            {
                { 1, 3 }, 
                { 5, 7 }
            };

            var secondArray = new double[,]
            {
                { 4, 2 }, 
                { 1, 5 }
                
            };

            var resultArray = MultuplyArrays(firstArray, secondArray);
            int resultRows = resultArray.GetLength(0);
            int resultCols = resultArray.GetLength(1);

            //Printing the result matrix
            for (int row = 0; row < resultRows; row++)
            {
                for (int col = 0; col < resultCols; col++)
                {
                    Console.Write(resultArray[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultuplyArrays(double[,] firstArray, double[,] secondArray)
        {
            if (firstArray.GetLength(1) != secondArray.GetLength(0))
            {
                throw new Exception("The number of cols of the first array should be equal to the number of rows of the second array");
            }

            var multiplyCells = firstArray.GetLength(1);
            var resultArray = new double[firstArray.GetLength(0), secondArray.GetLength(1)];

            for (int row = 0; row < resultArray.GetLength(0); row++)
            {
                for (int col = 0; col < resultArray.GetLength(1); col++)
                {
                    for (int currentCell = 0; currentCell < multiplyCells; currentCell++)
                    {
                        resultArray[row, col] += firstArray[row, currentCell] * secondArray[currentCell, col];
                    }
                }
            }         

            return resultArray;
        }
    }
}