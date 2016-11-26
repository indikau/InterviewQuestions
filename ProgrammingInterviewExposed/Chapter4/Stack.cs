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

        public void Push(ListElement<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("Given node is null, therefore we will not insert into the stack");
            }

            node.Next = root;
            root = node;
        }

        public T Pop()
        {
            var top = root;
            root = root.Next;
            return top.Value;
        }
    }
}
