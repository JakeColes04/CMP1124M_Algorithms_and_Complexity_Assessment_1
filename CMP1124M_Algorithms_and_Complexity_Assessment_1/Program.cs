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
    String line;
    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_1_256.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}

if (choice == "2")
{
    String line;
    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_1_2048.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}


if (choice == "3")
{
    String line;
    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_2_256.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}

if (choice == "4")
{
    String line;
    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_2_2048.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}

if (choice == "5")
{
    String line;
    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_3_256.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}

if (choice == "6")
{
    String line;
    try
    {

        StreamReader sr = new StreamReader("C:\\Users\\jakec\\source\\repos\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\CMP1124M_Algorithms_and_Complexity_Assessment_1\\Net_3_2048.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");
    }
}

