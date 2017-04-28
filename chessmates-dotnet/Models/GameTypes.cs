using NHibernate.Type;

namespace chessmates_dotnet.Models
{
    public enum GameTypes
    {
        Bullet,
        Blitz,
        Classical,
        Correspondence,
        Crazyhouse,
        Puzzle,
        Chess960,
        UltraBullet,
        Atomic,
        Antichess,
        ThreeCheck,
    }

    public class GameTypesType : EnumStringType
    {
        public GameTypesType() : base(typeof(GameTypes), 45)
        {
        }
    }
}