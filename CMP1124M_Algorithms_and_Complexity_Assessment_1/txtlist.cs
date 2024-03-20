using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_1
{
    internal class txtlist
    {
        public static string[] lists(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines;
        }
    }
}
