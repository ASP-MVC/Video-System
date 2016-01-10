using YouNoob.Data.Repositories;
using YouNoob.Models;

namespace YouNoob.Data.UoW
{
    public interface IYouNoobData
    {
        IDeletableEntityRepository<Channel> Channels { get; }

        IDeletableEntityRepository<Comment> Comments { get; }

        IDeletableEntityRepository<Video> Videos { get; }

        IRepository<User> Users { get; }

        IYouNoobDbContext Context { get; }

        int SaveChanges();
    }
}