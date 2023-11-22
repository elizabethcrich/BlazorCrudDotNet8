using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int? id);
        Task<Game> AddGame(Game game);
        Task<Game> UpdateGame(int Id, Game game);
    }
}
