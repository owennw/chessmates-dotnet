namespace chessmates_dotnet.Repositories
{
    using chessmates_dotnet.Lichess;
    using chessmates_dotnet.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public class PlayerRepository : IRepository<Player>
    {
        private IApiService<Player> apiService;

        public PlayerRepository()
        {
            this.apiService = new LichessApiService<Player>();
        }

        public async Task<Player[]> GetAll()
        {

            return await this.apiService.Get("user?team=scott-logic");
        }

        public async Task<Player> GetById(string id)
        {
            var players = await this.GetAll();

            return players.FirstOrDefault(p => p.Id == id);
        }
    }
}