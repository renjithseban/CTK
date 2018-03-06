using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class LocationInfo
    {
        [XmlAttribute(AttributeName ="altitude")]
        public float Altitude { get; set; }

        [XmlAttribute(AttributeName = "latitude")]
        public float Latitude { get; set; }

        [XmlAttribute(AttributeName = "longitude")]
        public float Longitude { get; set; }

        [XmlAttribute(AttributeName = "geobase")]
        public string Geobase { get; set; }

        [XmlAttribute(AttributeName = "geobaseid")]
        public float GeobaseId { get; set; }
    }
}