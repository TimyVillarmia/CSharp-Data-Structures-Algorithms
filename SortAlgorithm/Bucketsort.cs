using System;
using System.Collections.Generic;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test case arrays
            double[] list1 = { 0.42, 0.32, 0.33, 0.52, 0.37, 0.47, 0.51 };
            double[] list2 = { 0.12, 0.22, 0.92, 0.01, 0.78, 0.65, 0.34 };
            double[] list3 = { 0.76, 0.24, 0.45, 0.63, 0.18, 0.95, 0.87 };
            double[] list4 = { 0.55, 0.27, 0.73, 0.14, 0.69, 0.08, 0.40 };

            Console.WriteLine("Original array 1:");
            PrintArray(list1);
            BucketSort(list1);
            Console.WriteLine("Sorted array 1 using Bucket Sort:");
            PrintArray(list1);

            Console.WriteLine("Original array 2:");
            PrintArray(list2);
            BucketSort(list2);
            Console.WriteLine("Sorted array 2 using Bucket Sort:");
            PrintArray(list2);

            Console.WriteLine("Original array 3:");
            PrintArray(list3);
            BucketSort(list3);
            Console.WriteLine("Sorted array 3 using Bucket Sort:");
            PrintArray(list3);

            Console.WriteLine("Original array 4:");
            PrintArray(list4);
            BucketSort(list4);
            Console.WriteLine("Sorted array 4 using Bucket Sort:");
            PrintArray(list4);
        }
        /*
            Bucket Sort
            - Bucket Sort is a sorting algorithm that works well when the input data is uniformly distributed over a range.
            - It divides the range of input values into a set of "buckets," where each bucket is responsible for a subrange of values.
            - The input elements are distributed into these buckets based on their values.
            - Each bucket is then sorted individually, and the sorted buckets are concatenated to produce the final sorted output.
            - Bucket Sort can be efficient when the range of input values is not too large and the input distribution is relatively uniform.

            - Algorithm:
            1. Create an array of empty buckets.
            2. Scatter: Distribute the input elements into the buckets based on their values.
            3. Sort each individual bucket.
            4. Concatenate the sorted buckets to get the final sorted output.

            - Complexity Analysis:
            - Average Case: O(n + k) where n is the number of elements and k is the number of buckets.
            - Worst Case: O(n^2) when most elements fall into a single bucket and require a separate sort.
            - Best Case: O(n) when each element goes into a separate bucket.

            - Bucket Sort is suitable for sorting a large number of elements with a relatively uniform distribution.
            - It is often used as a sub-step in other sorting algorithms like Radix Sort.
        */

        static void PrintArray(double[] arr)
        {
            foreach (double num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void BucketSort(double[] array)
        {
            int n = array.Length;
            List<List<double>> buckets = new List<List<double>>();

            // Create empty buckets
            for (int i = 0; i < n; i++)
            {
                buckets.Add(new List<double>());
            }

            // Scatter: Distribute elements into buckets
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (int)(n * array[i]); // Calculate the index of the bucket
                buckets[bucketIndex].Add(array[i]);
            }

            // Sort individual buckets
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }

            // Concatenate sorted buckets to get the final sorted array
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                foreach (double num in buckets[i])
                {
                    array[index++] = num;
                }
            }
        }
    }
}