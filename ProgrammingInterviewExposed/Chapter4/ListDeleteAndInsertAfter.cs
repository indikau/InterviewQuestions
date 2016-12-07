/// <summary>
/// PROBLEM head and tail are global pointers to the first and last element, respectively,
/// of a singly linked list of integers.Implement C functions for the following
/// prototypes:
/// bool delete(Element* elem);
/// bool insertAfter(Element* elem, int data);
/// The argument to delete is the element to be deleted.The two arguments to
/// insertAfter give the element after which the new element is to be inserted and
/// the data for the new element.It should be possible to insert at the beginning of the
/// list by calling insertAfter with NULL as the element argument.These functions
/// should return a boolean indicating success.
/// Your functions must keep the head and tail pointers current.
/// </summary>

namespace ProgrammingInterviewExposed.Chapter4
{
    using ProgrammingInterviewExposed.Chapter4.Components;

    public class ListDeleteAndInsertAfter<T>
    {
        private ListElement<T> root, tail;
        public bool Delete(ListElement<T> elem)
        {
            //Given element is null.
            if (elem == null)
            {
                return false;
            }

            //List is empty.
            if (root == null)
            {
                return false;
            }

            //List with one element
            if (root == tail && root == elem)
            {
                root = null;
                tail = null;
                return true;
            }

            if(root == elem)
            {
                root = elem.Next;
                return true;
            }

            //List with more than one element.
            ListElement<T> curr = root;
            while (curr.Next != null)
            {
                if (curr.Next == elem)
                {
                    if (curr.Next == tail)
                    {
                        tail = curr;
                    }
                    curr = curr.Next.Next;
                    return true;
                }
            }
            //Given element not found.
            return false;
        }

        public bool InsertAfter(ListElement<T> elem, int data)
        {
            //List is empty.
            //List has one node.
            //List with more than one element.
            return false;
        }
    }
}
