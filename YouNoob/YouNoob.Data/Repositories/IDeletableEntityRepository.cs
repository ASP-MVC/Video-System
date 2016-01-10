using System.Linq;
using YouNoob.Models;

namespace YouNoob.Data.Repositories
{
    public interface IDeletableEntityRepository<T> : IRepository<T> 
        where T : IEntity
    {
        IQueryable<T> AllWithDeleted();
    }
}