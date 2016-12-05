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
        public bool Delete(ListElement<T> elem) { return false; }

        public bool InsertAfter(ListElement<T> elem, int data) { return false; }
    }
}
