using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class QuickSort
    {
        public static int[] QuickSorting(int[] array)
        {

            if (array.Length < 2)
            {
                return array;
            }
            else
            {
                int [] middleElement = new int[1];
                middleElement[0] = array[array.Length / 2];
                int lesserLength = 0;
                int greaterLength = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (middleElement[0] > array[i])
                    {
                        lesserLength += 1;
                    }
                    if (i == array.Length / 2)
                    {
                        continue;
                    }
                    if (middleElement[0] <= array[i])
                    {
                        greaterLength += 1;
                    }
                }
                int[] greaterArray = new int[greaterLength];
                int[] lesserArray = new int[lesserLength];
                int lesserCounter = 0;
                int greaterCounter = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (middleElement[0] > array[i])
                    {
                        lesserArray[lesserCounter] = array[i];
                        lesserCounter++;
                    }
                    if (i == array.Length / 2)
                    {
                        continue;
                    }
                    if (middleElement[0] <= array[i])
                    {
                        greaterArray[greaterCounter] = array[i];
                        greaterCounter++;
                    }
                }
                return QuickSorting(lesserArray).Concat(middleElement).Concat(QuickSorting(greaterArray)).ToArray();

            }

        }
    }
}
