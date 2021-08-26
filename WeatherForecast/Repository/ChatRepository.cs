using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Data;
using WeatherForecast.Models;

namespace WeatherForecast.Repository
{
    public class ChatRepository : IChatRepository
    {
        private AppDbContext _db;

        public ChatRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Chat chat)
        {
            await _db.Chats.AddAsync(chat);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Chat>> GetAllAsync()
        {
            return await _db.Chats.ToListAsync();
        }
    }
}
