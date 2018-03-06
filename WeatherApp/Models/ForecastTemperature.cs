using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastTemperature
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }

        [XmlAttribute(AttributeName = "min")]
        public float Min { get; set; }

        [XmlAttribute(AttributeName = "max")]
        public float Max { get; set; }
    }
}