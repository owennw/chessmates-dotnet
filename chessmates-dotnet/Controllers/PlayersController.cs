namespace chessmates_dotnet.Controllers
{
    using chessmates_dotnet.Models;
    using chessmates_dotnet.StubData;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    public class PlayersController : ApiController
    {
        private Player[] players;

        public PlayersController()
        {
            this.players = StubPlayers.GetPlayers();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return this.players;
        }

        public IHttpActionResult GetPlayer(string id)
        {
            var player = this.players.FirstOrDefault(p => p.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }
    }
}
