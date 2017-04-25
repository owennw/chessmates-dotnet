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

        public IHttpActionResult player(string id)
        {
            var product = this.players.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
