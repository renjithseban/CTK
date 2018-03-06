using System;
using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class ForecastTime
    {
        [XmlAttribute(AttributeName = "from")]
        public DateTime From { get; set; }

        [XmlAttribute(AttributeName = "to")]
        public DateTime To { get; set; }

        [XmlElement(ElementName ="symbol")]
        public ForecastSymbol ForecastSymbol { get; set; }

        [XmlElement(ElementName = "precipitation")]
        public ForecastPrecipitation ForecastPrecipitation { get; set; }

        [XmlElement(ElementName = "windDirection")]
        public ForecastWindDirection ForecastWindDirection { get; set; }

        [XmlElement(ElementName = "windSpeed")]
        public ForecastWindSpeed ForecastWindSpeed { get; set; }

        [XmlElement(ElementName = "temperature")]
        public ForecastTemperature ForecastTemperature { get; set; }

        [XmlElement(ElementName = "pressure")]
        public ForecastPressure ForecastPressure { get; set; }

        [XmlElement(ElementName = "humidity")]
        public ForecastHumidity ForecastHumidity { get; set; }

        [XmlElement(ElementName = "clouds")]
        public ForecastClouds ForecastClouds { get; set; }
    }
}