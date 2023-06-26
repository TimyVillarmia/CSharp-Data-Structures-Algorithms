<Query Kind="Program" />

void Main()
{
	int[] list_sorted = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	int[] list_unsorted = { 5, 9, 3, 7, 6, 8, 2, 1, 4, 10 };

	Console.WriteLine(LinearSearchAlgorithm_Unsorted(list_unsorted, 5));
	Console.WriteLine(LinearSearchAlgorithm_Sorted(list_sorted, 5));

}

// You can define other methods, fields, classes and namespaces here

/*
	
		1. Linear Search Algorithm (Unsorted)
	
		- When elements of an array are not ordered or sorted and we want to search 
		for a particular value, we need to scan the full list until we find the desired 
		value. This kind of algorithm is known as unordered linear search. The 
		major problem with this algorithm is less performance or high Time 
		Complexity in worst case. 
		
		- Time Complexity: O(n). As we need to traverse the complete list in worst 
		case. Worst case is when your desired element is at the last position of the
		array.Here, ‘n’ is the size of the array.
		
		- Space Complexity: O(1). No extra memory is used to allocate the array.
		
	*/

bool LinearSearch_Unsorted(int[] list, int target)
{

	for (int i = 0; i < list.Length; i++)
	{
		if (target == list[i])
		{
			return true;
		}

	}

	return false;
}

/*
	2. Linear Search Algorithm (Sorted)

	 - if elements of the array are sorted either in increasing order or in decreasing 
	   order, searching for a desired element will be much more efficient than 
	   unordered linear search. In many cases, we do not need to traverse the 
	   complete list. If the array is sorted in increasing order. We can traverse it 
	   from beginning and when we encounter a value greater than the key, we 
	   stop searching further and declare that the key is not present in the array. 
	   This is how this algorithm saves the time and improves the performance.

	 - Time Complexity: O(n). As we need to traverse the complete list in worst 
	   case. Worst case is when your desired element is at the last position of the 
	   sorted list. However, in the average case this algorithm is more efficient 
	   even though the growth rate is same as unsorted. 

	 - Space Complexity: O(1). No extra memory is used to allocate the array. 


*/

bool LinearSearch_Sorted(int[] list, int target)
{

	for (int i = 0; i < list.Length; i++)
	{
		if (target == list[i])
		{
			return true;
		}
		else if (target < list[i]) // Increasing Order
								   //else if (target > list[i) // Decreasing Order
		{
			return false;
		}

	}
	return false;



}

