namespace chessmates_dotnet.Models
{
    public class Perfs
    {
        public RatingStats Blitz { get; set; }
        public RatingStats Bullet { get; set; }
        public RatingStats Correspondence { get; set; }
        public RatingStats Puzzle { get; set; }
        public RatingStats Classical { get; set; }
    }
}