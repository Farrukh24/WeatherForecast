using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;
using static WeatherForecast.Models.WeatherDomain;

namespace WeatherForecast.Repository
{
    public interface IWeatherRepo
    {
       Task<Weather> GetInfoByCityAsync(string city);
       
    }
}
