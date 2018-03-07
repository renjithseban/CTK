﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public Coordinates CoOrd { get; set; }
    }
}