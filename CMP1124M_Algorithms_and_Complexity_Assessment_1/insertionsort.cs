using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_1
{
    internal class insertionsort
    {
        public static void insertionSort(int[] array)
        {
            int len = array.Length;
            for (int i = 1; i < len; ++i)
            {
                int currentValue = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > currentValue)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = currentValue;
                Console.WriteLine("Amount of steps taken: " + i);
            }
        }
    }
}
