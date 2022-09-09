

// Using out Parameters
class SwapNumber2
{
    public void SwapTwoNumbers2(int a, int b, out int c , out int d)
    {
        
        c = a;
        d = b;
    }

    public static void Main()
    {
        int a, b , c , d;
        Console.WriteLine("Enter the first number");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Values before swap is {0} and {1}", a, b);
        SwapNumber2 swapnumber = new SwapNumber2();
        swapnumber.SwapTwoNumbers2(a, b, out c , out d);
        a = d;
        b = c;
        Console.WriteLine("Values after swap is {0} and {1}", a, b);

    }
}

// Using array
/*class SwapNumber
{
    public int[] SwapTwoNumbers(int a, int b)
    {
        int[] result = new int[2];
        result[0] = b;
        result[1] = a;
        return result;
    }

    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter the first number");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Values before swap is {0} and {1}", a, b);
        int[] result = new int[2];
        SwapNumber swapnumber = new SwapNumber();
        result = swapnumber.SwapTwoNumbers(a, b);
        a= result[0];
        b= result[1];   
        Console.WriteLine("Values after swap is {0} and {1}", a,b);

    }
}*/