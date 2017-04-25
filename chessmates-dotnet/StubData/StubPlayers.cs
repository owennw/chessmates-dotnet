using chessmates_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.StubData
{
    public static class StubPlayers
    {
        private static Random random = new Random();

        public static Player[] GetPlayers()
        {
            Player[] players = new Player[]
            {
                new Player { Id = "tf235", Username = "tf235", Online = false, Perfs = CreatePerfs(), CreatedAt = 1411660632569, SeenAt = 1492538069039 },
                new Player { Id = "owennw", Username = "owennw", Online = true, Perfs = CreatePerfs() },
                new Player { Id = "jedrus07", Username = "jedrus07", Online = false, Perfs = CreatePerfs() },
            };

            return players;
        }

        private static Perfs CreatePerfs()
        {
            return new Perfs
            {
                Blitz = CreateGameType(),
                Bullet = CreateGameType(),
                Classical = CreateGameType(),
                Correspondence = CreateGameType(),
                Puzzle = CreateGameType(),
            };
        }

        private static GameType CreateGameType()
        {
            return new GameType { Games = random.Next(5000), Prog = random.Next(50), Rating = random.Next(3200) };
        }
    }
}