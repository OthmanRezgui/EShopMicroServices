using System.Runtime.Serialization;

namespace Catalog.API.Exceptions
{
    [Serializable]
    internal class ProductNotfoundException : Exception
    {
        public ProductNotfoundException()
        {
        }

        public ProductNotfoundException(string? message) : base(message)
        {
        }

        public ProductNotfoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ProductNotfoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}