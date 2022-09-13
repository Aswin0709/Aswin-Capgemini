using StackImplementation;
using System;
using System.Collections;
class program
{
    public static void Main()
    {
        Console.WriteLine("Enter size of the stack");
        int n = Convert.ToInt32(Console.ReadLine());
        int decision, contin;
        MyStack myStack = new MyStack(n);
        do
        {
            
            Console.WriteLine("Enter the function u want to perform: \n 1.Push \n 2.Pop");
            decision = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (decision == 1)
                {


                    Console.WriteLine("Enter the number you want to push");
                    int a = Convert.ToInt32(Console.ReadLine());
                    myStack.Push(a);

                }
                else if (decision == 2)
                {
                    Console.WriteLine(myStack.Pop());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.WriteLine("Enter 1 to continue");
            contin = Convert.ToInt32(Console.ReadLine());
        } while (contin == 1);
        

        /* Code for cloning 
         
        MyStack mystack2;
        mystack2 = MyStack.Clone(myStack);
        
        */
       

    }
}