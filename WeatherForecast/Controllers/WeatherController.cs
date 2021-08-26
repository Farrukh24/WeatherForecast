using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;
using WeatherForecast.Repository;

namespace WeatherForecast.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherRepo _repository;

        public WeatherController(IWeatherRepo repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
                
        public async Task<IActionResult> Detail([FromQuery] string search)
        {
            var model = await _repository.GetInfoByCityAsync(search);
                        
            if(model.main is null)
            {
                // TODO partial
                return PartialView("Error");
            }

            return PartialView("Details", model);
        }
    }

}


