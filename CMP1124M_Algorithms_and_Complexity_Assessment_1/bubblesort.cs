using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_1
{
    internal class bubblesort
    {
        public static void bubbleSort(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        
                    }
                    Console.WriteLine("Amount of steps taken: " + i);
                }
                
            }

        }
    }
}
 