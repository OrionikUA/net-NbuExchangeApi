using System.Collections.Generic;
using System.Xml.Serialization;

namespace Orionik.NbuExchangeApi.Xml
{
    [XmlRoot(ElementName = "exchange")]
    public class ExchangeList
    {
        [XmlElement(ElementName = "currency")]
        public List<Currency> Currency { get; set; }
    }
}
