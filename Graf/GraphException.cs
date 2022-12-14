using System.Runtime.Serialization;

namespace Graf
{
    [Serializable]
    internal class GraphException : Exception
    {
        public GraphException()
        {
        }

        public GraphException(string? message) : base(message)
        {
        }

        public GraphException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GraphException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}