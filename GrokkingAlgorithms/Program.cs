using GrokkingAlgorithms;
using System;

//Binary Search
//O(Log n)
int[] sortedArray = new int[] { 1, 5, 8, 10, 15, 17, 100, 102, 105, 203, 2005, 5001, 10000 };
Console.WriteLine(BinarySearch.FindIndex(sortedArray, 100)); // 6 
Console.WriteLine(BinarySearch.FindIndex(sortedArray, 200)); // null
Console.WriteLine(BinarySearch.FindIndex(sortedArray, 10000)); // 12
Console.WriteLine(BinarySearch.FindIndex(sortedArray, 1)); // 0
Console.WriteLine(BinarySearch.FindIndex(sortedArray, 2005)); // 10

