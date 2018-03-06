using System.Collections.Generic;
using System.Xml.Serialization;

namespace WeatherApp.Models
{
    public class Forecast
    {
        [XmlElement(ElementName ="time")]
        public List<ForecastTime> ForecastTime { get; set; }
        
    }
}