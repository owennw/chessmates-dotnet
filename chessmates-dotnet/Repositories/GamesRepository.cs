namespace chessmates_dotnet.Repositories
{
    using chessmates_dotnet.Lichess;
    using chessmates_dotnet.Models;
    using System.Collections;
    using System.Linq;
    using System.Threading.Tasks;

    public class GamesRepository : IRepository<Game>
    {
        private IApiService<Game> apiService;
        private PlayerRepository playerRepository;

        public GamesRepository()
        {
            this.apiService = new LichessApiService<Game>();
            this.playerRepository = new PlayerRepository();
        }

        public async Task<Game[]> GetAll()
        {
            var players = await this.playerRepository.GetAll();

            var playersCrossTable = players
                .SelectMany(p1 => players, (p1, p2) => new { a = p1, b = p2 })
                .Where(pc => pc.a != pc.b);

            var games = playersCrossTable
                .Select(async pc => await this.apiService.Get($"games/vs/{pc.a}/{pc.b}"));

            var jointTask = await Task.WhenAll(games);
            return jointTask.SelectMany(g => g).ToArray();
        }

        public async Task<Game> GetById(string id)
        {
            var games = await this.GetAll();

            return games.FirstOrDefault(g => g.Id == id);
        }
    }
}