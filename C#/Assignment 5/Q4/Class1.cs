
using System;
using System.Collections;
using System.Collections.Generic;


namespace StackImplementationUsingGenerics
{
    public class MyStack<T>
    {
        public int size;
        public int top;
        public T[] stack;


        public MyStack(int size)
        {
            this.size = size;
            stack = new T[this.size];
            top = -1;
        }
        public void Push(T value)
        {

            if (top >= size - 1)
            {

                throw new StackException("Stack Overflow");

            }
            else
            {
                stack[++top] = value;

            }


        }

        public T Pop()
        {

            if (top < 0)
            {
                throw new StackException("Stack Underflow");
            }
            else
            {
                T value = stack[top--];
                return value;
            }
        }

    }
    public class StackException : Exception
    {
        public StackException(string e) : base()
        {
            Console.WriteLine(e);
        }
    }
}
