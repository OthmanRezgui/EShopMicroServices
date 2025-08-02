using BuildingBlocks.Exceptions;
using System.Runtime.Serialization;

namespace Catalog.API.Exceptions
{
    [Serializable]
    internal class ProductNotfoundException : NotFoundException
    {
        public ProductNotfoundException()
        {
        }

        public ProductNotfoundException(Guid Id) : base("Product", Id)
        {
        }
    }
}