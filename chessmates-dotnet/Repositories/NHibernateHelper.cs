using chessmates_dotnet.Models;
using NHibernate;
using NHibernate.Cfg;

namespace chessmates_dotnet.Repositories
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly("chessmates_dotnet");
                    sessionFactory = configuration.BuildSessionFactory();
                }

                return sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}