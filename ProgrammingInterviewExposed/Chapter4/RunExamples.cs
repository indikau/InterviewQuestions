namespace ProgrammingInterviewExposed.Chapter4
{
    using System;

    public class RunExamples
    {
        private static Random rnd = new Random(2);
        public static void Main(string[] args)
        {
            RunStackExamples();
        }

        private static void RunStackExamples()
        {
            // Create stack
            Console.WriteLine("Create stack with value 10");
            var stack = new Stack<int>(GetRandomIntValue());
            // pop the stack
            Console.WriteLine("\t<= Pop from the stack :{0}", stack.Pop());
            try
            {
                Console.Write("\t<= Pop from the stack :");
                Console.Write(stack.Pop());
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine("\n\t\tStack is EMPTY: {0}",e.Message);
            }
            var value = GetRandomIntValue();
            Console.WriteLine("\t=> Push to the stack :{0}", value);
            stack.Push(value);
            value = GetRandomIntValue();
            Console.WriteLine("\t=> Push to the stack :{0}", value);
            stack.Push(value);
        }

        private static int GetRandomIntValue()
        {            
            return rnd.Next(0, 100);
        }
    }
}
