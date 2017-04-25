namespace chessmates_dotnet.Controllers
{
    using chessmates_dotnet.Models;
    using chessmates_dotnet.Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class GamesController : ApiController
    {
        private IRepository<Game> repository;

        public GamesController()
        {
            this.repository = new GamesRepository();
        }

        public async Task<Game[]> GetAllGames()
        {
            return await this.repository.GetAll();
        }

        public async Task<IHttpActionResult> GetGame(string id)
        {
            var match = await this.repository.GetById(id);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}
