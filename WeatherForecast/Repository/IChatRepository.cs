using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.Repository
{
    public interface IChatRepository
    {
        Task<List<Chat>> GetAllAsync();
        Task AddAsync(Chat chat);
    }
}
