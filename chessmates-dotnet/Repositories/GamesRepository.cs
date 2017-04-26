namespace chessmates_dotnet.Repositories
{
    using chessmates_dotnet.Lichess;
    using chessmates_dotnet.Models;
    using chessmates_dotnet.StubData;
    using System.Collections;
    using System.Linq;
    using System.Threading.Tasks;

    public class GamesRepository : IRepository<Game>
    {
        //private IApiService<Game> apiService;
        private Game[] games;

        public GamesRepository()
        {
            //this.apiService = new LichessApiService<Game>();
            this.games = StubGames.GetGames();
        }

        public async Task<Game[]> GetAll()
        {
            return await Task.Run(() => this.games);
        }

        public async Task<Game> GetById(string id)
        {
            var games = await this.GetAll();

            return games.FirstOrDefault(g => g.Id == id);
        }
    }
}