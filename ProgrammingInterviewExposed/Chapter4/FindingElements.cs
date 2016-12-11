namespace ProgrammingInterviewExposed.Chapter4
{
    using ProgrammingInterviewExposed.Chapter4.Components;

    public class FindingElements<T>
    {
        public ListElement<T> FindMToLastElement(ListElement<T> head, int m)
        {
            if (head == null)
            {
                return null;
            }

            ListElement<T> curr, mBehind;
            curr = head;
            for (int i = 0; i < m; i++)
            {
                if (curr.Next != null)
                {
                    curr = curr.Next;
                }else
                {
                    return null;
                }
            }

            mBehind = curr;
            while (curr.Next != null)
            {
                mBehind = mBehind.Next;
                curr = curr.Next;
            }
            return mBehind;
        }
    }
}
