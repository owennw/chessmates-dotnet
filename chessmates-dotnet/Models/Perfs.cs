namespace chessmates_dotnet.Models
{
    public class Perfs
    {
        private RatingStats blitz;
        private RatingStats bullet;
        private RatingStats correspondence;
        private RatingStats puzzle;
        private RatingStats classical;

        public RatingStats Blitz
        {
            get
            {
                return blitz;
            }
            set
            {
                value.GameType = GameTypes.Blitz;
                blitz = value;
            }
        }

        public RatingStats Bullet
        {
            get
            {
                return bullet;
            }
            set
            {
                value.GameType = GameTypes.Bullet;
                bullet = value;
            }
        }

        public RatingStats Correspondence
        {
            get
            {
                return correspondence;
            }
            set
            {
                value.GameType = GameTypes.Correspondence;
                correspondence = value;
            }
        }

        public RatingStats Classical
        {
            get
            {
                return classical;
            }
            set
            {
                value.GameType = GameTypes.Classical;
                classical = value;
            }
        }

        public RatingStats Puzzle
        {
            get
            {
                return puzzle;
            }
            set
            {
                value.GameType = GameTypes.Puzzle;
                puzzle = value;
            }
        }
    }
}