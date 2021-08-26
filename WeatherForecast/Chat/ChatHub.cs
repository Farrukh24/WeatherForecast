using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;
using WeatherForecast.Repository;

namespace WeatherForecast
{
    public class ChatHub: Hub
    {
      
        public async Task SendMessage(string name, string message)
        {            
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}
