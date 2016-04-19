namespace Assertions_Homework
{
    using System;

    public class AssertionsMain
    {
        private static void Main()
        {
            int[] arr = { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Assertions.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            try
            {
                Assertions.SelectionSort(new int[0]); // Test sorting empty array
                Assertions.SelectionSort(new int[1]); // Test sorting single element array  
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Assertions.BinarySearch(arr, -1000));
            Console.WriteLine(Assertions.BinarySearch(arr, 0));
            Console.WriteLine(Assertions.BinarySearch(arr, 17));
            Console.WriteLine(Assertions.BinarySearch(arr, 10));
            Console.WriteLine(Assertions.BinarySearch(arr, 1000));
        }
    }
}