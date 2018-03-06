using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastSymbol
    {
        [XmlAttribute(AttributeName = "number")]
        public int Number { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "var")]
        public string Var { get; set; }
    }
}