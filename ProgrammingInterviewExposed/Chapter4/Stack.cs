namespace ProgrammingInterviewExposed.Chapter4
{
    using System;
    using Components;

    public class Stack<T>
    {
        private ListElement<T> root;

        public Stack(T value)
        {
            this.root = new ListElement<T>(value, null);
        }

        public void Push(T value)
        {
            var node = new ListElement<T>(value, root);
            root = node;
        }

        public T Pop()
        {
            if (root == null)
            {
                throw new StackEmptyException("Stack is empty.");
            }

            var top = root.Value;
            root = root.Next;
            return top;
        }
    }
}
