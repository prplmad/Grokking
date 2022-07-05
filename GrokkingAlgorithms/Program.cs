using GrokkingAlgorithms;
using System;

////Binary Search
////O(Log n)
//int[] sortedArray = new int[] { 1, 5, 8, 10, 15, 17, 100, 102, 105, 203, 2005, 5001, 10000 };
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 100)); // 6 
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 200)); // null
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 10000)); // 12
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 1)); // 0
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 2005)); // 10

//Selection Sort
//O(n^2)

int[] nonSortedArray = new int[] {6,2,88,1,4,7,9,106,1000,101,0,20,67,31,1001,3 };
int[] newArray = SelectionSort.SelectionSorting(nonSortedArray);
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}


