using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastHumidity
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }

    }
}