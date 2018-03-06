using System;

namespace WeatherApp.Models
{
    public class Meta
    {
        public DateTime LastUpdate { get; set; }

        public float CalcTime { get; set; }

        public DateTime NextUpdate { get; set; }
    }
}