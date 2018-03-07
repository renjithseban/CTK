using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WeatherApp.Models
{
    public class HomeViewModel
    {
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<string> Countries { get; set; }
        private Regex rgx = new Regex(@"^[a-zA-Z]");

        [Display(Name = "City")]
        public string CityName { get; set; }

        public IEnumerable<SelectListItem> CityItems
        {
            get
            {
                var cities = Cities.Where(c=>rgx.IsMatch(c.Name) && rgx.IsMatch(c.Country))
                                        .Take(20000)
                                        .Select(f => new SelectListItem
                                        {
                                            Value = f.Name,
                                            Text = f.Name
                                        })
                                        .OrderBy(lst => lst.Text);
                return cities;
            }
        }

        [Display(Name = "Country")]
        public string CountryName { get; set; }

        public IEnumerable<SelectListItem> CountryItems
        {
            get
            {
                var countries = Countries.Select(f => new SelectListItem
                                        {
                                            Value = f.ToString(),
                                            Text = f.ToString()
                                        })
                                        .OrderBy(lst => lst.Text);
                return countries;
            }
        }

        public HomeViewModel()
        {
            Cities = LoadJson();
        }

        private List<City> LoadJson()
        {
            using (StreamReader r = new StreamReader(@"E:\Projects\CTK\city.list.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<City>>(json);
            }
        }
    }
}