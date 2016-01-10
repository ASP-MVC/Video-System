using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using YouNoob.Models;

namespace YouNoob.Data
{
    public interface IYouNoobDbContext
    {
        IDbSet<Channel> Channels { get; set; }
        IDbSet<Comment> Comment { get; set; }
        IDbSet<Genre> Genres { get; set; }
        IDbSet<Video> Videos { get; set; }

        DbContext DbContext { get; }

        int SaveChanges();

        void Dispose();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}