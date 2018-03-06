using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class Location
    {
        [XmlElement(ElementName ="name")]
        public string Name { get; set; }

        [XmlElement(ElementName ="type",IsNullable =true)]
        public string Type { get; set; }

        [XmlElement(ElementName ="country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "timezone", IsNullable = true)]
        public string Timezone { get; set; }

        [XmlElement(ElementName ="location")]
        public LocationInfo LocationInfo { get; set; }
    }
}