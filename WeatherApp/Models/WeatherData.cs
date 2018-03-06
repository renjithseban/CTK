using System.Xml.Serialization;

namespace WeatherApp.Models
{
    [XmlRoot(ElementName ="weatherdata")]
    public class WeatherData
    {
        [XmlElement(ElementName ="location")]
        public Location Location { get; set; }

        [XmlElement(ElementName ="meta")]
        public Meta Meta { get; set; }

        [XmlElement(ElementName ="forecast")]
        public Forecast Forecast { get; set; }
    }
}