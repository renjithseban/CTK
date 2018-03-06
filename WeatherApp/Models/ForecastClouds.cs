using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastClouds
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "all")]
        public int All { get; set; }

        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
    }
}