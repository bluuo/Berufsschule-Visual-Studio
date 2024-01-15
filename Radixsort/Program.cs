using System;

class Program
{
    static int steps = 0;
    static void Main()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("|            Radixsort Demo             |");
        Console.WriteLine("-----------------------------------------");

        int[][] testArrays = new int[][]
    {
        new int[] { 170, 45, 75, 90, 802, 24, 2, 66 },
        new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 },
        new int[] { 50, 30, 20, 10, 5, 2, 1 },
        new int[] { 1000, 100, 10, 1 },
        new int[] { 46633131, 654849761, 465, 3 ,4653516 },
        new int[] {100,23,5,123,55,450,1,29,999,7,234,3,
89,34,123,789,178,478,5,11,87,345,367,67,199,890,23,
56,6,8,12,34,90,2,8,13,800,567,345,   23,14,589,23,53,92,   
743,89,13,345,780,45,189,900,12,56,34,19,346,12,34,189},
          
    };

        
        foreach (int[] arr in testArrays) {
            steps = 0;
            Console.WriteLine("Original Array:");
            PrintArray(arr);


            var watch = System.Diagnostics.Stopwatch.StartNew();
            RadixSort(arr);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            var elapsedTicks = watch.ElapsedTicks; 

            Console.WriteLine("Sorted Array:");
            PrintArray(arr);
            Console.WriteLine("Processing Steps:" + steps);
            Console.WriteLine("Time elapsed:" + elapsedMs + "ms");
            Console.WriteLine("Ticks elapsed:" + elapsedTicks + " Ticks");
            Console.WriteLine("------------------------");
        }
        Console.ReadLine();
    }


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
        steps++;
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

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
