using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;
using WeatherForecast.Repository;

namespace WeatherForecast.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRepository _service;

        public ChatController(IChatRepository service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allChats = await _service.GetAllAsync();

            return View(allChats);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string name, string message)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(new Chat
                {
                    Name = name,
                    Message = message,
                    CreatedOn = DateTime.Now
                });
                
                return Ok();
            }
            else
            {
                return Ok("Please fill the given inputs!");
            }
            
        }
    }
}
