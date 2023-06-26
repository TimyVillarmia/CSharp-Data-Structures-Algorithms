<Query Kind="Program" />

void Main()
{
	int[] list_sorted = {1,2,3,4,5,6,7,8,9,10};
	
	Console.WriteLine(BinarySearchAlgorithm(list_sorted,0));

}


// You can define other methods, fields, classes and namespaces here

/*

	   3. Binary Search

	   Note: Binary search requires the array to be sorted otherwise binary search 
	   cannot be applied.

	  - Binary Search also works in the same way. When we want to search some 
	   key value in a sorted list. We go to the middle point from the sorted list and 
	   start comparing with the desired value. If the desired value is equal to the 
	   middle value then we are done. If the value is greater than the middle value 
	   then we reject the first half. If the value is less than the middle value then 
	   we reject the second half. At each comparison, we are reducing our search 
	   space by half. 

	  - Time Complexity: O(logn). We always take half input and throw out the 
	   other half. So the recurrence relation for binary search is T(n) = T(n/2) + c. 
	   Using master theorem (divide and conquer), we get T(n) = O(logn) 

	  - Space Complexity: O(1)

*/

bool BinarySearchAlgorithm(int[] list, int target)
{
	int left = 0; // first index of the list
	int right = list.Length - 1; //last index of the list
	int mid;

	while (left <= right)
	{

		mid = (left + right) / 2; // middle index of the list 

		if (list[mid] == target)
		{
			return true;

		}
		else if (target < list[mid])
		{
			right = mid - 1; //move the right pointer to the middle of the list
		}
		else
		{
			left = mid + 1; //move the left pointer to the middle of the list
		}



	}
	return false;


}