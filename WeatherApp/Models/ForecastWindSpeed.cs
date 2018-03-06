using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastWindSpeed
    {
        [XmlAttribute(AttributeName = "mps")]
        public float Mps { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}