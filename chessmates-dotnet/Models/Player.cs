using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace chessmates_dotnet.Models
{
    public class Player
    {
        private IList<RatingStats> ratingStats = new List<RatingStats>();

        public virtual string Id { get; set; }
        public virtual string Username { get; set; }
        public virtual Perfs Perfs { get; set; }
        public virtual bool Online { get; set; }
        public virtual long CreatedAt { get; set; }
        public virtual long SeenAt { get; set; }

        [JsonIgnore]
        public virtual IList<RatingStats> RatingStats
        {
            get { return this.ratingStats; }
            set { this.ratingStats = value; }
        }

        public override string ToString()
        {
            return this.Id;
        }
    }
}