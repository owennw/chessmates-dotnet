namespace chessmates_dotnet.Models
{
    public class Game
    {
        public virtual string Id { get; set; }
        public virtual bool Rated { get; set; }
        public virtual string Variant { get; set; }
        public virtual string Speed { get; set; }
        public virtual GameTypes Perf { get; set; }
        public virtual long CreatedAt { get; set; }
        public virtual long LastMoveAt { get; set; }
        public virtual int Turns { get; set; }
        public virtual string Color { get; set; }
        public virtual string Status { get; set; }
        public virtual Clock Clock { get; set; }
        public virtual Players Players { get; set; }
        public virtual string Winner { get; set; }
        public virtual string Url { get; set; }
    }
}