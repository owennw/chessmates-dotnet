using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.Models
{
    public class Perfs
    {
        public GameType Blitz { get; set; }
        public GameType Bullet { get; set; }
        public GameType Correspondence { get; set; }
        public GameType Puzzle { get; set; }
        public GameType Classical { get; set; }
    }
}