namespace chessmates_dotnet.Models
{
    public class Player
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public Perfs Perfs { get; set; }
        public bool Online { get; set; }
        public long CreatedAt { get; set; }
        public long SeenAt { get; set; }
    }
}