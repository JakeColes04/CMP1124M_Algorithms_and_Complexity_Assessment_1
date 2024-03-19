using System.IO;


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
    try
    {
        //Path to the text file
        string filePath = "C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_1_256.txt";

        // Reads all lines from the text file and put it into an array
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Unsorted list:");
        // Display each line in the array
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
    catch (Exception ex)
    {
        // Handle any exceptions
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}

if (choice == "2")
{
    try
    {
        string filePath = "C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_1_2048.txt";

        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Unsorted list:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}


if (choice == "3")
{
    try
    {
        string filePath = "C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_2_256.txt";

        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Unsorted list:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}


if (choice == "4")
{
    try
    {
        string filePath = "C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_2_2048.txt";

        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Unsorted list:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}


if (choice == "5")
{
    try
    {

        string filePath = "C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_3_256.txt";


        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Unsorted list:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}


if (choice == "6")
{
    try
    {

        string filePath = "C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_3_2048.txt"

        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Unsorted list:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine("An error occurred: " + ex.Message);
    }
}

