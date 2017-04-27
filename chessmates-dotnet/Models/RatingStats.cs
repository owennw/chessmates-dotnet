namespace chessmates_dotnet.Models
{
    using Newtonsoft.Json;

    public class RatingStats
    {
        public int Id { get; set; }
        public int Games { get; set; }
        public int Rating { get; set; }
        public int Prog { get; set; }
        public int Rd { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [JsonIgnore]
        public GameTypes GameType { get; set; }
    }
}