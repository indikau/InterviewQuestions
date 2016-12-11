namespace ProgrammingInterviewExposed.Chapter4.Components
{
    public class Node<T>
    {
        public Node(T value, Node<T> next, Node<T> prev, Node<T> child)
        {
            Value = value;
            Next = next;
            Prev = prev;
            Child = child;
        }

        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Prev { get; set; }

        public Node<T> Child { get; set; }

    }
}
