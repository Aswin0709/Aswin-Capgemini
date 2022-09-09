class maxmarks
{
    public static void Main()
    {
        int[] Marks = new int[5];

        for (int i = 0; i < Marks.Length; i++)
        {
            Console.WriteLine("Enter Mark of Student{0}", i + 1);
            Marks[i] = int.Parse(Console.ReadLine());

        }
        int max = Marks[0];
        for (int j = 1; j < Marks.Length; j++)
        {
            if (Marks[j] > max)
            {
                max = Marks[j];
            }
        }

        Console.WriteLine("The maximum of the marks is {0}", max);
    }
}