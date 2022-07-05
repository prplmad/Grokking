using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class SelectionSort
    {

        public static int[] SelectionSorting(int [] array)
        {
            for (int i = 0; i < array.Length - 2; i++)
            {
                int smallestIndex = i;
                int temp = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[smallestIndex] > array[j])
                    {
                        smallestIndex = j;
                    }
                }
                temp = array[i];
                array[i] = array[smallestIndex];
                array[smallestIndex] = temp;
            }
            return array;
        }
    }
}
