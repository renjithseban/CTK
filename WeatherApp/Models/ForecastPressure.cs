using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastPressure
    {
        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }

        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
    }
}