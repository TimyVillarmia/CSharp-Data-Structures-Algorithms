<Query Kind="Program" />

void Main()
{
	int[] array = new int[] { 3, 4, 2, 1, 6, 5, 7, 8, 1, 1 };
	MergeSort.sort(array);
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
}

// You can define other methods, fields, classes and namespaces here

/*
	Merge sort divide the input into two half recursively. In each step, the data 
	is divided into two half. The two parts are sorted separately and finally 
	combine the result into final sorted output.
	
*/

public class MergeSort
{
	public static void merge(int[] arr, int[] tempArray, int lowerIndex, int middleIndex, int upperIndex)
	{
		int lowerStart = lowerIndex;
		int lowerStop = middleIndex;
		int upperStart = middleIndex + 1;
		int upperStop = upperIndex;
		int count = lowerIndex;

		while (lowerStart <= lowerStop && upperStart <= upperStop)
		{
			if (arr[lowerStart] < arr[upperStart])
			{
				tempArray[count++] = arr[lowerStart++];
			}
			else
			{
				tempArray[count++] = arr[upperStart++];
			}
		}

		while (lowerStart <= lowerStop)
		{
			tempArray[count++] = arr[lowerStart++];
		}
		while (upperStart <= upperStop)
		{
			tempArray[count++] = arr[upperStart++];
		}
		for (int i = lowerIndex; i <= upperIndex; i++)
		{
			arr[i] = tempArray[i];
		}
	}

	public static void mergeSrt(int[] arr, int[] tempArray, int lowerIndex, int upperIndex)
	{

		if (lowerIndex >= upperIndex)
			return;

		int middleIndex = (lowerIndex + upperIndex) / 2;
		mergeSrt(arr, tempArray, lowerIndex, middleIndex);
		mergeSrt(arr, tempArray, middleIndex + 1, upperIndex);
		merge(arr, tempArray, lowerIndex, middleIndex, upperIndex);
	}
	
	public static void sort(int[] arr)
	{
		int size = arr.Length;
		int[] tempArray = new int[size];
		mergeSrt(arr, tempArray, 0, size - 1);
	}
}

/*
	Analysis:
		• Time Complexity of Merge-Sort is O(nlogn) in all 3 cases (best,
		average and worst) as Merge-Sort always divides the array into two
		halves and takes linear time to merge two halves.
		• It requires the equal amount of additional space as the unsorted array.
		Hence, it is not at all recommended for searching large unsorted arrays.
		• It is the best Sorting technique for sorting Linked Lists.
		
	Complexity Analysis: 
	Worst Case time complexity 	  |	O(nlogn) 
	Best Case time complexity 	  | O(nlogn) 
	Average case time complexity  |	O(nlogn) 
	Space Complexity 			  | O(n) 
	Stable Sorting 				  | Yes
*/