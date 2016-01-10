using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YouNoob.Models
{
    public class Channel : Entity
    {
        public Channel()
        {
            this.ChannelVideos = new HashSet<Video>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public virtual ICollection<Video> ChannelVideos { get; set; }
    }
}