using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YouNoob.Models
{
    public class Genre : Entity
    {
        public Genre()
        {
            this.Videos = new HashSet<Video>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Video> Videos { get; set; } 
    }
}