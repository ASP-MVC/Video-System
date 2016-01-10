using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using YouNoob.Models;

namespace YouNoob.Data
{
    public class YouNoobDbContext: IdentityDbContext<User>, IYouNoobDbContext
    {
        public YouNoobDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Channel> Channels { get; set; }

        public IDbSet<Comment> Comment { get; set; }

        public IDbSet<Genre> Genres { get; set; }

        public IDbSet<Video> Videos { get; set; }

        public DbContext DbContext
        {
            get { return this; }
        }

        public IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static YouNoobDbContext Create()
        {
            return new YouNoobDbContext();
        }
    }
}