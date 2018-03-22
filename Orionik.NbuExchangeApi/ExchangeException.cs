using System;

namespace Orionik.NbuExchangeApi
{
    public class ExchangeException : Exception
    {
        public ExchangeException(string message) : base(message) { }
        public ExchangeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
