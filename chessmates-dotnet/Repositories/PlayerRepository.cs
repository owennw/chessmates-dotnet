using chessmates_dotnet.Models;
using chessmates_dotnet.StubData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.Repositories
{
    public class PlayerRepository : IRepository<Player>
    {
        private Player[] players;

        public PlayerRepository()
        {
            this.players = StubPlayers.GetPlayers();
        }

        public Player[] GetAll()
        {
            return this.players;
        }

        public Player GetById(string id)
        {
            return this.GetAll().FirstOrDefault(p => p.Id == id);
        }
    }
}