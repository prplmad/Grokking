using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class BinarySearch
    {
        //Log2N
        public static object FindIndex(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid;
            int guess;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = array[mid];
                if (guess == number)
                    return mid;
                if (guess > number)
                    high = mid - 1;
                if (guess < number)
                    low = mid + 1;
            }
            return "Значение не найдено";
        }

    }
}
