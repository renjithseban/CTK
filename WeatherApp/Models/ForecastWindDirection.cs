using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastWindDirection
    {
        [XmlAttribute(AttributeName = "deg")]
        public float Deg { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "names")]
        public string Name { get; set; }
    }
}