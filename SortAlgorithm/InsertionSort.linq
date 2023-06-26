<Query Kind="Program" />

void Main()
{
	int[] list = { 5, 9, 3, 7, 6, 8, 2, 1, 4, 10 };
	InsertionSort(list);

	for (int i = 0; i < list.Length; i++)
	{
		Console.Write(list[i] + " ");
	}

}

// You can define other methods, fields, classes and namespaces here

/*
    Insertion-Sort Time Complexity is O(𝐧𝟐) which is same as Bubble-Sort but
    perform a bit better than it. It is the way we arrange our playing cards. We 
    keep a sorted subarray. Each value is inserted into its proper position in the 
    sorted sub-array in the left of it. 
 
 */

bool more(int value1, int value2)
{
	return value1 > value2;
}

void InsertionSort(int[] arr)
{
	int size = arr.Length;
	int temp, j;
	for (int i = 1; i < size; i++)
	{
		temp = arr[i];
		for (j = i; j > 0 && more(arr[j - 1], temp); j--)
		{
			arr[j] = arr[j - 1];
		}
		arr[j] = temp;
	}
}

/*
	 Analysis:
		• The outer loop is used to pick the value we want to insert into the
		sorted array in left.

		• The value we want to insert we have picked and saved in a temp
		variable.

		• The inner loop is doing the comparison using the more() function.
		The values are shifted to the right until we find the proper position
		of the temp value for which we are doing this iteration.

		• Finally, the value is placed into the proper position. In each iteration
		of the outer loop, the length of the sorted array increase by one.
		When we exit the outer loop, the whole array is sorted.

		Complexity Analysis: 
		Worst case time complexity   |  O(n^2) 
		Best case time complexity    |  O(n) 
		Average case time complexity |  O(n^2) 
		Space Complexity             |  O(1) 
		Stable sorting               |  Yes

 */