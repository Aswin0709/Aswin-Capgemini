// See https://aka.ms/new-console-template for more information
class Calculator
{
    public void Calculation(int a, int b, char op) 
    {
        switch (op)
        {
            case '+':
                Console.WriteLine("The sum of the two number {0} and {1} is {2}", a,b,a+b);
                break;
            case '-':
                Console.WriteLine("The difference of the two number {0} and {1} is {2}", a, b,a-b);
                break;
            case '*':
                Console.WriteLine("The product of the two number {0} and {1} is {2}",a,b,a*b);
                break;
            case '/':
                Console.WriteLine("The Quotient of the two number {0} and {1} is {2}", a,b,a/b);
                break;
        }
    }


public static void Main()
    {
        int number, a, b;
        
            
            Console.WriteLine("CALCULATOR APPLICATION");
            //Reading first number
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            //Reading second numbere
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operator(+ , -, *, /)");
            char op = (char)Console.Read();
            new Calculator().Calculation(a, b, op);
        Console.WriteLine("Press 1 to continue calculating");
        


    }
}
