using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList(); // Creating an array list
        // Get input from the user
        Console.WriteLine("Enter numbers (enter 'done' when finished):");
        string input;
        do
        {
            input = Console.ReadLine();
            if (input.ToLower() != "done")
            {
                if (int.TryParse(input, out int num))
                {
                    arrayList.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'done' to finish.");
                }
            }
        } while (input.ToLower() != "done");

        List<int> uniqueNumbers = FindUniqueNumber(arrayList);
        if (uniqueNumbers.Count > 0)
        {
            Console.WriteLine("The unique numbers in the array list are:");
            foreach (int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No unique numbers found in the array list.");
        }
    }

    static List<int> FindUniqueNumber(ArrayList arrayList)
    {
        // Initialize a dictionary 
        Dictionary<int, int> numberCount = new Dictionary<int, int>();

        // Count each number in the array list
        foreach (int num in arrayList)
        {
            if (numberCount.ContainsKey(num))
            {
                numberCount[num]++;
            }
            else
            {
                numberCount[num] = 1;
            }
        }

        // Find the number that only one 
        List<int> uniqueNumbers = new List<int>();
        foreach (var kvp in numberCount)
        {
            if (kvp.Value == 1)
            {
                uniqueNumbers.Add(kvp.Key);
            }
        }

        // Return list of unique numbers
        return uniqueNumbers;
    }
}

