using ProgrammingInterviewExposed.Chapter4.Components;

namespace ProgrammingInterviewExposed.Chapter4
{
    public class Acyclic<T>
    {
        public bool IsAcyclic(ListElement<T> head)
        {
            ListElement<T> curr2 = head;
            ListElement<T> curr = head;
            if (curr.Next == null)
                return true;

            while (curr2.Next.Next != null)
            {
                curr2 = curr2.Next.Next;
                curr = curr.Next;
                if (curr == curr2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
