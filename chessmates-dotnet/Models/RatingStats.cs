namespace chessmates_dotnet.Models
{
    using Newtonsoft.Json;

    public class RatingStats
    {
        public virtual int Id { get; set; }
        public virtual int Games { get; set; }
        public virtual int Rating { get; set; }
        public virtual int Prog { get; set; }
        public virtual int Rd { get; set; }

        [JsonIgnore]
        public virtual Player Player { get; set; }

        [JsonIgnore]
        public virtual GameTypes GameType { get; set; }

        public override string ToString()
        {
            return this.GameType.ToString();
        }
    }
}