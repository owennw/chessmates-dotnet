namespace chessmates_dotnet.Repositories
{
    using chessmates_dotnet.Lichess;
    using chessmates_dotnet.Models;
    using NHibernate;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class PlayerRepository : IRepository<Player>
    {
        private IApiService<Player> apiService;

        public PlayerRepository()
        {
            this.apiService = new LichessApiService<Player>();
        }

        public async Task<Player[]> GetAll()
        {
            var players = await this.apiService.Get("user?team=scott-logic");

            this.RefreshCache(players);

            return players;
        }

        public async Task<Player> GetById(string id)
        {
            var players = await this.GetAll();

            return players.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Player player)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(player);
                    transaction.Commit();
                }
            }
        }

        public void AddBulk(Player[] players)
        {
            foreach (var player in players)
            {
                var perfs = player.Perfs;
                var addStatsToPlayer = this.AddStats(player);

                addStatsToPlayer(perfs.Blitz);
                addStatsToPlayer(perfs.Classical);
                addStatsToPlayer(perfs.Bullet);
                addStatsToPlayer(perfs.Puzzle);
                addStatsToPlayer(perfs.Correspondence);
            }

            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    foreach (var player in players)
                    {
                        session.SaveOrUpdate(player);
                    }

                    transaction.Commit();
                }
            }
        }

        private void RefreshCache(Player[] players)
        {
            this.AddBulk(players);
        }

        private Action<RatingStats> AddStats(Player player)
        {
            return stats =>
            {
                if (stats != null)
                {
                    stats.Player = player;
                    player.RatingStats.Add(stats);
                }
            };
        }
    }
}