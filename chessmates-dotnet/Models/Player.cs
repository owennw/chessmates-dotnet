namespace chessmates_dotnet.Models
{
    public class Player
    {
        public virtual string Id { get; set; }
        public virtual string Username { get; set; }
        public virtual Perfs Perfs { get; set; }
        public virtual bool Online { get; set; }
        public virtual long CreatedAt { get; set; }
        public virtual long SeenAt { get; set; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}