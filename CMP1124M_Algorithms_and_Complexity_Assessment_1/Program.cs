using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: Net_1_256.txt");
            Console.WriteLine("2: Net_1_2048.txt");
            Console.WriteLine("3: Net_2_256.txt");
            Console.WriteLine("4: Net_2_2048.txt");
            Console.WriteLine("5: Net_3_256.txt");
            Console.WriteLine("6: Net_3_2048.txt");
            Console.WriteLine("Please select what file you would like to sort and search");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                
                foreach (string line in txtlist.lists(@"C:\Users\jakec\source\repos\CMP1124M_Algorithms_and_Complexity_Assessment_1\CMP1124M_Algorithms_and_Complexity_Assessment_1\Net_1_256.txt"))
                {
                    Console.WriteLine(line);
                    Int32.TryParse(line, out int[] net1_256);
                    bubblesort.bubbleSort(line);
                }
            }
            if (choice == "2")
            {
                foreach (string line in txtlist.lists(@"C:\Users\jakec\source\repos\CMP1124M_Algorithms_and_Complexity_Assessment_1\CMP1124M_Algorithms_and_Complexity_Assessment_1\Net_1_2048.txt"))
                {
                    Console.WriteLine(line);
                    string net1_2048 = line;
                }
            }
            if (choice == "3")
            {
                foreach (string line in txtlist.lists(@"C:\Users\jakec\source\repos\CMP1124M_Algorithms_and_Complexity_Assessment_1\CMP1124M_Algorithms_and_Complexity_Assessment_1\Net_2_256.txt"))
                {
                    Console.WriteLine(line);
                    string net2_256 = line;
                }
            }
            if (choice == "4")
            {
                foreach (string line in txtlist.lists(@"C:\Users\jakec\source\repos\CMP1124M_Algorithms_and_Complexity_Assessment_1\CMP1124M_Algorithms_and_Complexity_Assessment_1\Net_2_2048.txt"))
                {
                    Console.WriteLine(line);
                    string net2_2048 = line;
                }
            }
            if (choice == "5")
            {
                foreach (string line in txtlist.lists(@"C:\Users\jakec\source\repos\CMP1124M_Algorithms_and_Complexity_Assessment_1\CMP1124M_Algorithms_and_Complexity_Assessment_1\Net_3_256.txt"))
                {
                    Console.WriteLine(line);
                    string net3_256 = line;
                }
            }
            if (choice == "6")
            {
                foreach (string line in txtlist.lists(@"C:\Users\jakec\source\repos\CMP1124M_Algorithms_and_Complexity_Assessment_1\CMP1124M_Algorithms_and_Complexity_Assessment_1\Net_3_2048.txt"))
                {
                    Console.WriteLine(line);
                    string net3_2048 = line;
                }
            }
        }
    }
}
