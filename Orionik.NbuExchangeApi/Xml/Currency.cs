using System.Xml.Serialization;

namespace Orionik.NbuExchangeApi.Xml
{
    [XmlRoot(ElementName = "currency")]
    public class Currency
    {
        [XmlElement(ElementName = "r030")]
        public string Code { get; set; }
        [XmlElement(ElementName = "txt")]
        public string UaName { get; set; }
        [XmlElement(ElementName = "rate")]
        public string Rate { get; set; }
        [XmlElement(ElementName = "cc")]
        public string EnName { get; set; }
        [XmlElement(ElementName = "exchangedate")]
        public string ExchangeDate { get; set; }
    }
}
