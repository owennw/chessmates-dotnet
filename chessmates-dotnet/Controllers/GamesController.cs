namespace chessmates_dotnet.Controllers
{
    using chessmates_dotnet.Models;
    using chessmates_dotnet.StubData;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    public class GamesController : ApiController
    {
        private Game[] matches;

        public GamesController()
        {
            this.matches = StubGames.GetGames();
        }

        public IEnumerable<Game> GetAllGames()
        {
            return this.matches;
        }

        public IHttpActionResult GetGame(string id)
        {
            var match = this.matches.FirstOrDefault(m => m.Id == id);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}
