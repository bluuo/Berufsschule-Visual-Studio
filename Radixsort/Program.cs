using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("|            Radixsort Demo             |");
        Console.WriteLine("-----------------------------------------");

        int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
        Console.WriteLine("\nOriginal Array:");
        PrintArray(arr);

        RadixSort(arr);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);

        Console.ReadLine();
    }

    // A utility function to get the maximum value in an array
    static int GetMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    // A function to perform counting sort of arr based on the digit represented by exp
    static void CountSort(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10]; // There are 10 possible digits (0-9)

        // Initialize count array
        for (int i = 0; i < 10; i++)
        {
            count[i] = 0;
        }

        // Count the occurrences of each digit in the current position (exp)
        for (int i = 0; i < n; i++)
        {
            count[(arr[i] / exp) % 10]++;
        }

        // Calculate the cumulative count
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Build the output array in sorted order
        for (int i = n - 1; i >= 0; i--)
        {
            output[count[(arr[i] / exp) % 10] - 1] = arr[i];
            count[(arr[i] / exp) % 10]--;
        }

        // Copy the output array back to arr
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }

        // Print the current state of the array
        Console.WriteLine("\nIntermediate Step (exp = " + exp + "):");
        PrintArray(arr);
    }

    // The main radix sort function
    static void RadixSort(int[] arr)
    {
        int max = GetMax(arr);

        // Perform counting sort for every digit, starting from the least significant digit (LSD)
        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(arr, exp);
        }
    }

    // A utility function to print an array
    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
