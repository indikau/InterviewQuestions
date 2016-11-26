namespace ProgrammingInterviewExposed.Chapter4.Components
{
    public class ListElement<T>
    {
        public ListElement<T> Next { get; set; }

        public T Value { get; set; }

        public ListElement() { }

        public ListElement(T value, ListElement<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
