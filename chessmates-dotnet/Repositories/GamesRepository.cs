namespace chessmates_dotnet.Repositories
{
    using chessmates_dotnet.Lichess;
    using chessmates_dotnet.Models;
    using System;
    using System.Collections;
    using System.Linq;
    using System.Threading.Tasks;

    public class GamesRepository : IRepository<Game>
    {
        private IApiService<Game> apiService;

        public GamesRepository()
        {
            this.apiService = new LichessApiService<Game>();
        }

        public async Task<Game[]> GetAll()
        {
            return await this.apiService.Get("/user/owennw/games?nb=1000");
        }

        public async Task<Game> GetById(string id)
        {
            var games = await this.GetAll();

            return games.FirstOrDefault(g => g.Id == id);
        }

        public void Add(Game game)
        {
            throw new NotImplementedException();
        }
    }
}