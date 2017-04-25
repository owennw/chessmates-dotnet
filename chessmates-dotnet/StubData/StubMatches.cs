using chessmates_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.StubData
{
    public static class StubGames
    {
        public static Game[] GetGames()
        {
            Game[] matches = new Game[]
            {
                new Game
                {
                    Id = "5qjuNkTD",
                    Rated = false,
                    Variant = "standard",
                    Speed = "classical",
                    Perf = "classical",
                    CreatedAt = 1483956239488,
                    LastMoveAt = 1483956784888,
                    Turns = 15,
                    Color = "black",
                    Clock = CreateClock(3600, 60, 6000),
                    Players = new Players
                    {
                        White = new GamePlayer { UserId = "tf235", Rating = 1773 },
                        Black = new GamePlayer { UserId = "owennw", Rating = 1524 },
                    },
                    Winner = "white",
                },
                new Game
                {
                    Id = "tZtLeWY1",
                    Rated = true,
                    Variant = "standard",
                    Speed = "bullet",
                    Perf = "bullet",
                    CreatedAt = 1465405992697,
                    LastMoveAt = 146540622279,
                    Turns = 45,
                    Color = "black",
                    Clock = CreateClock(120, 1, 160),
                    Players = new Players
                    {
                        White = new GamePlayer { UserId = "sydeman", Rating = 1276, RatingDiff = 15 },
                        Black = new GamePlayer { UserId = "torrlane", Rating = 1403, RatingDiff = -16 },
                    },
                    Winner = "white",
                }
            };

            return matches;
        }

        private static Clock CreateClock(int initial, int increment, int totalTime)
        {
            return new Clock
            {
                Initial = initial,
                Increment = increment,
                TotalTime = totalTime
            };
        }
    }
}