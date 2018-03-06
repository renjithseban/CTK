using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastPrecipitation
    {
        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }

    }
}