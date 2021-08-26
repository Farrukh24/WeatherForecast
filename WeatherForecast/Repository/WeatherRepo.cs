using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using WeatherForecast.Models;
using Newtonsoft.Json;

namespace WeatherForecast.Repository
{
    public class WeatherRepo : IWeatherRepo
    {
        private readonly string BASE_URL;
        private readonly string KEY;

        public WeatherRepo(IConfiguration config)
        {
            BASE_URL = config.GetSection("API").GetSection("BaseUrl").Value;
            KEY = config.GetSection("API").GetSection("KEY").Value;
        }

        public async Task<Weather> GetInfoByCityAsync(string city)
        {
            var client = new RestClient(string.Format(BASE_URL, city, KEY));
            var request = new RestRequest(Method.GET);
            var response = await client.GetAsync<IEnumerable<Weather>>(request);            

            return response.FirstOrDefault();
        }
    }
}
