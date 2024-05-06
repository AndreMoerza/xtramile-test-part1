using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList() { 5, 7, 2, 8, 4, 1, 15 }; // Example array list

        int[] maxSumPair = FindMaxSumPair(arrayList);
        if (maxSumPair != null)
        {
            Console.WriteLine("The pair with the maximum sum is: " + maxSumPair[0] + " and " + maxSumPair[1]);
            Console.WriteLine("Maximum sum: " + (maxSumPair[0] + maxSumPair[1]));
        }
        else
        {
            Console.WriteLine("Array list does not contain enough elements to find a pair.");
        }
    }

    static int[] FindMaxSumPair(ArrayList arrayList)
    {
        if (arrayList.Count < 2)
            return null; // Not enough elements to form a pair

        int[] maxPair = new int[2];
        int maxSum = int.MinValue;

        // Iterate through the array list to find the pair with maximum sum
        for (int i = 0; i < arrayList.Count - 1; i++)
        {
            for (int j = i + 1; j < arrayList.Count; j++)
            {
                int sum = (int)arrayList[i] + (int)arrayList[j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxPair[0] = (int)arrayList[i];
                    maxPair[1] = (int)arrayList[j];
                }
            }
        }

        return maxPair;
    }
}
