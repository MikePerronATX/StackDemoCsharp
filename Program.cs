using System;

namespace Stack
{
    class Program
    {
        static void Main (string[]args)
        {
            var stack = new Stack();
            Console.WriteLine("Adding numbers");
            Console.WriteLine("Printing numbers");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // stack.Push(4);
            
            stack.Display();

            stack.Pop();
            stack.Display();
            // 
        }
    }
}