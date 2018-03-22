using System.Xml.Serialization;

namespace Orionik.NbuExchangeApi.Xml
{
    [XmlRoot(ElementName = "exchange")]
    public class Exchange
    {
        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }
    }
}
