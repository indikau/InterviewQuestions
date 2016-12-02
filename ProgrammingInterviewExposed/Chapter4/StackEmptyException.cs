using System;
using System.Runtime.Serialization;

namespace ProgrammingInterviewExposed.Chapter4
{
    [Serializable]
    internal class StackEmptyException : Exception
    {
        public StackEmptyException()
        {
        }

        public StackEmptyException(string message) : base(message)
        {
        }

        public StackEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StackEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}