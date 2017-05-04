namespace chessmates_dotnet.Controllers
{
    using chessmates_dotnet.Models;
    using chessmates_dotnet.Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class PlayersController : ApiController
    {
        private IRepository<Player> repository;

        public PlayersController()
        {
            this.repository = new PlayerRepository();
        }

        [Authorize(Roles = "ChessmatesUser")]
        public async Task<Player[]> GetAllPlayers()
        {
            var players = await this.repository.GetAll();

            return players;
        }

        public async Task<IHttpActionResult> GetPlayer(string id)
        {
            var player = await this.repository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }
    }
}
