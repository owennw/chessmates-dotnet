namespace chessmates_dotnet.Repositories
{
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        Task<T[]> GetAll();
        Task<T> GetById(string id);
    }
}