using System;
using System.Diagnostics;
using System.Linq;

internal class Assertions
{
    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        if (arr.Length == 0)
        {
            throw new ArgumentNullException("BinarySearch cannot be achieved on an empty string");
        }

        if (value == null)
        {
            throw new NullReferenceException("The searched value must not be null");
        }

        int index = BinarySearch(arr, value, 0, arr.Length - 1);
        bool valueExistButNotFound = !(index == -1 && arr.Contains(value));
        bool valueNotExistButFound = !(index != -1 && !arr.Contains(value));
        Debug.Assert(valueExistButNotFound, "BinarySearch does not work correctly. Value exitst but is not found");
        Debug.Assert(
            valueNotExistButFound, 
            "BinarySearch does not work correctly. Value does not exist but returned that it exist");

        return index;
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        if (arr.Length == 0)
        {
            throw new ArgumentNullException("The collection is empty, cannot achieve selection sort.");
        }

        if (arr.Length == 1)
        {
            throw new InvalidOperationException("Selection sort cannot be achieved on collection with only 1 element");
        }

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int nextIndex = index + 1;
            Debug.Assert(
                arr[index].CompareTo(arr[nextIndex]) < 0, 
                string.Format("Selection sort is not working. Error at index {0} ", index));
        }
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) where T : IComparable<T>
    {
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
    {
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }
}