<Query Kind="Program" />

void Main()
{

	int[] list = { 5, 9, 3, 7, 6, 8, 2, 1, 4, 10 };
	BubbleSort(list);
	
	for(int i = 0; i < list.Length; i++)
	{
		Console.Write(list[i] + " ");
	}
}

// You can define other methods, fields, classes and namespaces here

/*
         Bubble Sort
            - is the slowest algorithm for sorting
            - it is easy to implement and used when data is small
         
        How it works?
            - we compare each pair of adjacent values
            - if we want to sort values:
                • Ascending Order
                    - if the second values is lesser than the first values then swap these two values. 
                      Otherwise, we will go to the next pair. 
                • Descending Order
                    - if the second values is greater than the first values then swap these two values
                      Otherwise, we will go to the next pair.
            - We will have N number of passes to get the array completely sorted

        Analysis:
            • The outer loop represents the number of swaps that are done for
            comparison of data.

            • The inner loop is actually used to do the comparison of data. At the end
            of each inner loop iteration, the largest value is moved to the end of the
            array. In the first iteration the largest value, in the second iteration the
            second largest and so on.

            • more() function is used for comparison which means when the value of
            the first argument is greater than the value of the second argument then
            perform a swap. By this we are sorting in increasing order if we have,
            the less() function in place of more() then array will be sorted in
            decreasing order.

            Complexity Analysis: 

            Each time the inner loop execute for (n-1), (n-2), (n-3)…(n-1) + (n-2) + (n3) + ..... + 3 + 2 + 1 = n(n-1)/2 
           
            Worst case performance   | O(n^2) 
            Average case performance | O(n^2) 
            Space Complexity         | O(1) as we need only one temp variable 
            Stable Sorting           | Yes 

    */

bool Ascending(int value1, int value2)
{
	return value1 > value2;
}


bool Descending(int value1, int value2)
{
	return value1 < value2;
}

void BubbleSort(int[] list)
{

	int size = list.Length;
	int i, j, temp;

	// outer loop represents the numnber of swaps/passes that are done for comparison data
	for (i = 0; i < size; i++)
	{
		// inner loop is used to do the comparison data
		for (j = 0; j < size - i - 1; j++)
		{
			if (Ascending(list[j], list[j + 1]))
			{
				//Swapping
				temp = list[j];
				list[j] = list[j + 1];
				list[j + 1] = temp;
			}
		}
	}

}

/*
	Modified (improved) Bubble-Sort
	 - When there is, no more swap in one pass of the outer loop the array is 
	 already sorted. At this point, we should stop sorting. This sorting 
	 improvement in Bubble-Sort is extremely useful when we know that, except 
	 few elements rest of the array is already sorted.

	 By applying this improvement, best-case performance of this algorithm is 
	 improved when an array is nearly sorted. In this case, we just need one 
	 single pass and the best-case complexity is O(n)

	 Complexity Analysis: 
	 Worst case performance    | O(n^2) 
	 Average case performance  | O(n^2) 
	 Space Complexity          | O(1) 
	 Adaptive: When array is   | O(n) 
	 nearly sorted             |
	 Stable Sorting            | Yes

*/

void ModifiedBubbleSort(int[] list)
{
	int size = list.Length;
	int i, j, temp, swapped = 1;

	for (i = 0; i < size && swapped == 1; i++)
	{
		swapped = 0;
		for (j = 0; j < size - i - 1; j++)
		{
			if (Ascending(list[j], list[j + 1]))
			{
				//Swapping
				temp = list[j];
				list[j] = list[j + 1];
				list[j + 1] = temp;
				swapped = 1;
			}
		}
	}
}
