using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class WeatherDataController : Controller
    {
        HttpClient client;
        string url = @"http://api.openweathermap.org/data/2.5/forecast?q=London,us&mode=xml&APPID=cbc6157d4fd3d3a74d9e1daa9eaf1a0a";
        public WeatherDataController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
        }
        // GET: WeatherData
        public async Task<ActionResult> Index()
        {
            WeatherData weatherData = new WeatherData();

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                XmlSerializer serializer = new XmlSerializer(typeof(WeatherData));
                weatherData = (WeatherData)serializer.Deserialize(new StringReader(responseData));

            }
            return View(weatherData);
        }


        // GET: WeatherData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeatherData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WeatherData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeatherData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WeatherData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeatherData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
