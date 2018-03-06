using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CTK.Controllers
{
    public class WeatherController : Controller
    {

        HttpClient client;
        const string APPID = "cbc6157d4fd3d3a74d9e1daa9eaf1a0a";
        string url = "http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=cbc6157d4fd3d3a74d9e1daa9eaf1a0a";
        

        public WeatherController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: Weather
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                //var userEntities = JsonConvert.DeserializeObject<IEnumerable<UserEntity>>(responseData);

                //var users = Mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(userEntities);
                //return View(users);
            }
            return View();
        }
    }
}