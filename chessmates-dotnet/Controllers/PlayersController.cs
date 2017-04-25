namespace chessmates_dotnet.Controllers
{
    using chessmates_dotnet.Models;
    using chessmates_dotnet.Repositories;
    using System.Collections.Generic;
    using System.Web.Http;

    public class PlayersController : ApiController
    {
        private IRepository<Player> repository;

        public PlayersController()
        {
            this.repository = new PlayerRepository();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return this.repository.GetAll();
        }

        public IHttpActionResult GetPlayer(string id)
        {
            var player = this.repository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }
    }
}
