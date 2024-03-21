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
                string filePath = @"file\Net_1_256.txt";

                string[] lines = File.ReadAllLines(filePath);

                int[] numbers = Array.ConvertAll(lines, int.Parse);

                bubblesort.bubbleSort(numbers);

                Console.WriteLine("Bubblesort complete");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("Write what number you want: ");
                string search = Console.ReadLine();
                int target = Convert.ToInt32(search);
                linearsearch.search(numbers, target);
            }

            if (choice == "2")
            {
                string filePath = @"file\Net_1_2048.txt";

                string[] lines = File.ReadAllLines(filePath);

                int[] numbers = Array.ConvertAll(lines, int.Parse);

                bubblesort.bubbleSort(numbers);

                Console.WriteLine("Bubblesort complete");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            if (choice == "3")
            {
                string filePath = @"file\Net_2_256.txt";

                string[] lines = File.ReadAllLines(filePath);

                int[] numbers = Array.ConvertAll(lines, int.Parse);

                insertionsort.insertionSort(numbers);

                Console.WriteLine("Insertion sort complete");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        
            if (choice == "4")
            {
                string filePath = @"file\Net_2_2048.txt";

                string[] lines = File.ReadAllLines(filePath);

                int[] numbers = Array.ConvertAll(lines, int.Parse);

                insertionsort.insertionSort(numbers);

                Console.WriteLine("Insertion sort complete");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            if (choice == "5")
            {
                foreach (string line in txtlist.lists(@"file\Net_3_256.txt"))
                {
                    Console.WriteLine(line);
                    string net3_256 = line;
                }
            }

            if (choice == "6")
            {
                foreach (string line in txtlist.lists(@"file\Net_3_2048.txt"))
                {
                    Console.WriteLine(line);
                    string net3_2048 = line;
                }
            }
        }
     }
}
