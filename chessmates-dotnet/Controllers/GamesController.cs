namespace chessmates_dotnet.Controllers
{
    using chessmates_dotnet.Models;
    using chessmates_dotnet.Repositories;
    using System.Collections.Generic;
    using System.Web.Http;

    public class GamesController : ApiController
    {
        private IRepository<Game> repository;

        public GamesController()
        {
            this.repository = new GamesRepository();
        }

        public IEnumerable<Game> GetAllGames()
        {
            return this.repository.GetAll();
        }

        public IHttpActionResult GetGame(string id)
        {
            var match = this.repository.GetById(id);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}
