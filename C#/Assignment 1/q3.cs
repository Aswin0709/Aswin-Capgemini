// See https://aka.ms/new-console-template for more information

using System;
class Assignment
{
    public static int Add(params int[] ListNumbers)
    {
        int total = 0;

        foreach (int i in ListNumbers)
        {
            total += i;
        }
        return total;
    }

    public static void Main(string[] args)
    {
        
        int result = Add(1, 2, 3, 4, 5, 6);
        Console.WriteLine(result);

    }
}