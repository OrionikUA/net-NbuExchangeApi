using Orionik.NbuExchangeApi.Xml;
using Orionik.XmlSerialization;

namespace Orionik.NbuExchangeApi
{
    internal static class Deserializer
    {
        public static Exchange DeserializeExchangeOne(string text)
        {
            return XmlObjectSerializer.DeserializeString<Exchange>(text);
        }

        public static ExchangeList DeserializeExchangeList(string text)
        {
            return XmlObjectSerializer.DeserializeString<ExchangeList>(text);
        }
    }
}
