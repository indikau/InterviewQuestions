using System;
using ProgrammingInterviewExposed.Chapter4.Components;

namespace ProgrammingInterviewExposed.Chapter4
{
    public class ListFlattening<T>
    {
        public void FlattenList(Node<T> head,Node<T> tail)
        {
            Node<T> curr = head;
            while (curr != null)
            {
                if (curr.Child != null)
                {
                    Append(curr.Child, tail);
                }
                curr = curr.Next;
            }
        }

        private void Append(Node<T> child, Node<T> tail)
        {
            Node<T> curr;

            tail.Next = child;
            child.Prev = tail;

            curr = child;

            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            tail = curr;
        }
    }
}
