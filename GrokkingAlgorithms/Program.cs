using GrokkingAlgorithms;
using System;

#region Binary Search
////Binary Search
////O(Logn)

//int[] sortedArray = new int[] { 1, 5, 8, 10, 15, 17, 100, 102, 105, 203, 2005, 5001, 10000 };
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 100)); // 6 
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 200)); // null
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 10000)); // 12
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 1)); // 0
//Console.WriteLine(BinarySearch.FindIndex(sortedArray, 2005)); // 10
#endregion

#region Selection Sort
////Selection Sort
////O(n^2)

//int[] nonSortedArray = new int[] { 6, 2, 88, 1, 4, 7, 9, 106, 1000, 101, 0, 20, 67, 31, 1001, 3 };
//int[] newArray = SelectionSort.SelectionSorting(nonSortedArray);
//for (int i = 0; i < newArray.Length; i++)
//{
//    Console.WriteLine(newArray[i]);
//}
#endregion

#region Quick Sort
////Quick sort 
//// O(n * Logn)
//Random rnd = new Random(DateTime.Now.Millisecond);

//int[] array = new int[1000000];

//for (int i = 0; i < 1000000; i++)
//{
//    int i_rnd = rnd.Next(1, 100000);
//    array[i] = i_rnd;
//}

//int[] answer = QuickSort.QuickSorting(array);
#endregion

#region Breath_FirstSearch

Dictionary<string, string []> graph = new();
graph["you"] = new string[] { "alice", "bob", "claire" };
graph["bob"] = new string[] { "anuj", "peggy"};
graph["alice"] = new string[] { "peggy" };
graph["claire"] = new string[] { "thom", "jonny" };
graph["anuj"] = new string[] { };
graph["peggy"] = new string[] { };
graph["thom"] = new string[] { };
graph["jonny"] = new string[] { };

Breath_FirstSearch.Breath_FirstSearching(graph, "you");


#endregion



