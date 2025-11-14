using System;

namespace FloristeriaMG.Infrastructure.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message) { }
    }
}
