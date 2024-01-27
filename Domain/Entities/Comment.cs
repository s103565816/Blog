using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [ForeignKey("Post")]
        public int PostId { get; set; }

        public Post Post { get; set; }

        [Required]
        public string CommentHeader { get; set; } = string.Empty;

        [Required]
        public string CommentText { get; set; } = string.Empty;

        [Required]
        public DateTime CommentTime { get; set; }
    }
}
