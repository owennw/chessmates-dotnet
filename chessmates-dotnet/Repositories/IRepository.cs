using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chessmates_dotnet.Repositories
{
    public interface IRepository<T> where T : class
    {
        T[] GetAll();
        T GetById(string id);
    }
}