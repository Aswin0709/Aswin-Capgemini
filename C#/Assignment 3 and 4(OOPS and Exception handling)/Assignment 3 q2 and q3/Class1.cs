using System;

namespace StackImplementation
{
    public class MyStack
    {
        public int size;
        public int top;
        public int[] stack;


        public MyStack(int size)
        {
            this.size = size;
            stack = new int[100];
            top = -1;
        }
        public void Push(int value)
        {
            
                if (top >= size-1)
                {
                    
                    throw new StackException("Stack Overflow");

                }
                else
                {
                    stack[++top] = value;
                    
                }
            
           
        }

        public int Pop()
        {
            
                if (top < 0)
                {
                    throw new StackException("Stack Underflow");
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            
            
        }

        public static MyStack Clone(MyStack mystack)
        {
             MyStack mystack2 = new MyStack(mystack.size);
              mystack2.top = mystack.top;
              
              mystack2.size = mystack.size;
             for(int i= 0; i<mystack.size;i++)
             {
                mystack2.stack[i] = mystack.stack[i]; 
             }

              return mystack2;

        }
    }

      public interface ICloneables
      {
           MyStack Clones(MyStack mystack);
      }
        
      public class StackException : Exception
      {
            public StackException(string e):base()
            {
                Console.WriteLine(e);
            }
      }

    
}
