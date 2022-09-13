
using System;

namespace Assignment4q1
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements to be entered");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine($"Enter element {j+1}");
                numbers[j] = Convert.ToInt32(Console.ReadLine());  

            }
            int[] temp = new int[n];
            
            Console.Write("The Original Array before any Operations: ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // copy the array
            Array.Copy(numbers,temp,n);
            Console.Write("Copied Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(temp);
            Console.Write("Sorted Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //clear the array
            Array.Clear(temp);
            Console.Write("Cleared Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}