using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.Models
{
    public class Game
    {
        public string Id { get; set; }
        public bool Rated { get; set; }
        public string Variant { get; set; }
        public string Speed { get; set; }
        public string Perf { get; set; }
        public long CreatedAt { get; set; }
        public long LastMoveAt { get; set; }
        public int Turns { get; set; }
        public string Color { get; set; }
        public Clock Clock { get; set; }
        public Players Players { get; set; }
        public string Winner { get; set; }
    }
}