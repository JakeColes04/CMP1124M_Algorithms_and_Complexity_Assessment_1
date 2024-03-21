using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_1
{
    internal class linearsearch
    {
        public static int search(int[] array, int target)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                if (array[i] == target)
                {
                    Console.WriteLine("Number found at index: " + i);
                    Console.WriteLine("Number of steps taken: " + i);
                    return i;
                }
            }
            Console.WriteLine("Number not found");
            return -1;
        }
    }
}
