/// <summary>
/// Discuss the stack data structure. Implement a stack in C using either
/// a linked list or a dynamic array, and justify your decision.Design the interface to
/// your stack to be complete, consistent, and easy to use.
/// </summary>
namespace ProgrammingInterviewExposed.Chapter4
{
    using Components;
    /// <summary>
    /// Implementation of the stack using linked list.
    /// </summary>
    /// <typeparam name="T">Type of the value</typeparam>
    public class Stack<T>
    {
        private ListElement<T> root;

        /// <summary>
        /// Initializing the class <see cref="Stack{T}"/>.
        /// </summary>
        /// <param name="value">Initial value.</param>
        public Stack(T value)
        {
            this.root = new ListElement<T>(value, null);
        }

        /// <summary>
        /// Push value to the stack
        /// </summary>
        /// <param name="value">Value to push to the stack</param>
        public void Push(T value)
        {
            var node = new ListElement<T>(value, root);
            root = node;
        }

        /// <summary>
        /// Pop the stack.
        /// </summary>
        /// <returns>Top value of the stack.</returns>
        /// <exception cref="StackEmptyException">Throws when the stack is empty.</exception>
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
