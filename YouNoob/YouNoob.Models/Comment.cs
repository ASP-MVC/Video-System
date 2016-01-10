using System.ComponentModel.DataAnnotations;

namespace YouNoob.Models
{
    public class Comment : Entity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(1500, MinimumLength = 1)]
        public string Content { get; set; }

        [Required]
        public string CommentedById { get; set; }

        public virtual User CommentedBy { get; set; }
    }
}