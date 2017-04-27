namespace chessmates_dotnet.Models
{
    public class GamePlayer
    {
        public string UserId { get; set; }
        public int Rating { get; set; }
    }

    public class Players
    {
        public GamePlayer White { get; set; }
        public GamePlayer Black { get; set; }
    }
}