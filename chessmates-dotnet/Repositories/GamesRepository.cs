using chessmates_dotnet.Models;
using chessmates_dotnet.StubData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.Repositories
{
    public class GamesRepository : IRepository<Game>
    {
        private Game[] games;

        public GamesRepository()
        {
            this.games = StubGames.GetGames();
        }

        public Game[] GetAll()
        {
            return this.games;
        }

        public Game GetById(string id)
        {
            return this.GetAll().FirstOrDefault(g => g.Id == id);
        }
    }
}