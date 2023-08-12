using System;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are the test case arrays
            int[] list1 = { 5, 9, 3, 7, 6, 8, 2, 1, 4, 10 };
            int[] list2 = { 34, 12, 78, 45, 23, 56, 89, 32, 67, 90 };
            int[] list3 = { 15, 10, 5, 20, 25, 30, 35, 40 };

            Console.WriteLine("Original array 1:");
            PrintArray(list1);

            QuickSort(list1, 0, list1.Length - 1);

            Console.WriteLine("Sorted array 1 using Quick Sort:");
            PrintArray(list1);

            Console.WriteLine("Original array 2:");
            PrintArray(list2);

            QuickSort(list2, 0, list2.Length - 1);

            Console.WriteLine("Sorted array 2 using Quick Sort:");
            PrintArray(list2);

            Console.WriteLine("Original array 3:");
            PrintArray(list3);

            QuickSort(list3, 0, list3.Length - 1);

            Console.WriteLine("Sorted array 3 using Quick Sort:");
            PrintArray(list3);

            /*Output : 
                    Original array 1:
                    5 9 3 7 6 8 2 1 4 10 
                    Sorted array 1 using Quick Sort:
                    1 2 3 4 5 6 7 8 9 10 
                    Original array 2:
                    34 12 78 45 23 56 89 32 67 90 
                    Sorted array 2 using Quick Sort:
                    12 23 32 34 45 56 67 78 89 90 
                    Original array 3:
                    15 10 5 20 25 30 35 40 
                    Sorted array 3 using Quick Sort:
                    5 10 15 20 25 30 35 40
            */
        }
        /*
            Quick Sort 
            -QuickSort is a sorting algorithm based on the Divide and Conquer algorithm that picks an element
             as a pivot and partitions the given array around the picked pivot by placing the pivot in its correct 
             position in the sorted array.
           
            -Quick Sort algorithm works:
            --Partitioning:
                The first step of Quick Sort is to select a pivot element from the array. 
                The choice of pivot can vary, but a common approach is to select the last element of the array. 
                The goal of partitioning is to rearrange the array in such a way that elements less than the pivot
                are on the left side, and elements greater than the pivot are on the right side.

            --Partition Process:
                After selecting the pivot, the array is partitioned into two subarrays
                 – one with elements less than the pivot and another with elements greater than the pivot.
                 This partitioning is achieved by iterating through the array using two pointers – one starting 
                 from the left (called left), and another starting from the right (called right).

                If array[i] is less than or equal to the pivot, the left pointer is moved to the right.
                If array[i] is greater than the pivot, the right pointer is moved to the left.
                If the values at the left and right pointers need to be swapped, they are swapped.
                This process continues until the left pointer crosses the right pointer. At this point, the left pointer indicates the position where the pivot should be placed.

            --Placing the Pivot:
                After the partitioning process, the pivot element is swapped with the element at the left pointer. 
                This positions the pivot element in its correct sorted position in the array.

            --Recursive Sorting:
                With the pivot in its correct position, the array is now divided into two subarrays.
                The left subarray contains elements less than the pivot, and the right subarray contains elements greater than the pivot.
                Quick Sort is then recursively applied to both subarrays.
            
            --Termination:
                The recursion terminates when subarrays of size 1 or 0 are reached. Arrays of these sizes are already sorted.

            The key insight of Quick Sort is that once the pivot is in its correct sorted position, you don't need to sort the elements on the left and right of the pivot together. They can be sorted independently using recursive calls. This "divide and conquer" strategy is what makes Quick Sort efficient.

            --Complexity Analysis:

            Average Case:     O(n log n)
            Worst Case:       O(n^2)        (when the pivot choice consistently leads to unbalanced partitioning)
            Best Case:        O(n log n)    (when the pivot choice consistently leads to balanced partitioning)
            Space Complexity: O(log n)      (for the call stack in the recursive function calls)
            
            --Quick Sort is widely used in practice due to its good average-case performance, making
            it suitable for large datasets. However, in situations where worst-case performance is a concern, other algorithms
            like Merge Sort or Heap Sort might be preferred. 
            
        */
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Quick Sort algorithm
        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(array, left, right);

                // Recursively sort the subarrays on the left and right of the pivot
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        // Partition function for Quick Sort
        static int Partition(int[] array, int left, int right)
        {
            int pivotValue = array[right]; // Choose the pivot as the last element
            int pivotIndex = left - 1;

            // Iterate through the subarray and rearrange elements around the pivot
            for (int i = left; i < right; i++)
            {
                if (array[i] <= pivotValue)
                {
                    pivotIndex++;
                    Swap(array, pivotIndex, i); // Swap elements to place smaller ones on the left
                }
            }

            Swap(array, pivotIndex + 1, right); // Place the pivot value in its correct position

            return pivotIndex + 1; // Return the index of the pivot
        }

        // Swap function
        static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}