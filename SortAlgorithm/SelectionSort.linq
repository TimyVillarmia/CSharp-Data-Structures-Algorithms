<Query Kind="Program" />

void Main()
{
	int[] list = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
	SelectionSortFront(list);
	//SelectionSortBack(list);
	
	for (int i = 0; i < list.Length; i++)
	{
		Console.Write(list[i] + " ");
	}
}

// You can define other methods, fields, classes and namespaces here

/*
	Selection-Sort

	Selection-Sort traverse the unsorted array and put the largest value at the 
	end of it. This process is repeated (n-1) number to times. This algorithm 
	also have quadratic time complexity. but performs better than both bubble 
	and Insertion-Sort as less number of swaps are required. The sorted array 
	is created backward in Selection-Sort. 


*/

void SelectionSortBack(int[] arr) // sorted array created from back.
{
	int size = arr.Length;
	int i, j, max, temp;
	for (i = 0; i < size - 1; i++)
	{
		max = 0;
		for (j = 1; j < size - 1 - i; j++)
		{
			if (arr[j] > arr[max])
			{
				max = j;
			}
		}
		temp = arr[size - 1 - i];
		arr[size - 1 - i] = arr[max];
		arr[max] = temp;
	}
}

/*
	Analysis:

		• The outer loop decides the number of times the inner loop will
		iterate.For an input of N elements, the inner loop will iterate N
		number of times.

		• In each iteration of the inner loop, the largest value is calculated
		and is placed at the end of the array.

		• This is the final replacement of the maximum value to the proper
		location.The sorted array is created backward.

		Complexity Analysis: 
		Worst Case time complexity      | O(n^2)
		Best Case time complexity       | O(n^2)
		Average case time complexity    | O(n^2)
		Space Complexity                | O(1)
		Stable Sorting                  | No

		The same algorithm can be implemented by creating the sorted array in the
		front of the array.
 */

void SelectionSortFront(int[] arr) // sorted array created from front
{
	int size = arr.Length;
	int i, j, min, temp;
	for (i = 0; i < size - 1; i++)
	{
		min = i;
		for (j = i + 1; j < size; j++)
		{
			if (arr[j] < arr[min])
			{
				min = j;
			}
		}
		temp = arr[i];
		arr[i] = arr[min];
		arr[min] = temp;
	}
}
