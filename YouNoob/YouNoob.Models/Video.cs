using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YouNoob.Models
{
    public class Video : Entity
    {
        public Video()
        {
            this.Genres = new HashSet<Genre>();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string VideoUrl { get; set; }

        public int VideoLength { get; set; }

        public string UploaderId { get; set; }

        public virtual User Uploader { get; set; }

        public virtual ICollection<Genre>  Genres { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } 
    }
}