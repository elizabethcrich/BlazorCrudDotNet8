﻿using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }
    }
}