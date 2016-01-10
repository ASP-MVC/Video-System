using System;
using YouNoob.Contracts.Models;

namespace YouNoob.Models
{
    public abstract class Entity : AuditInfo, IEntity, IDeletableEntity
    {
        public Entity()
        {
            this.CreatedOn = DateTime.Now;
        }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}