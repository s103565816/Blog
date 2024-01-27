using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PostTag
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post? Post { get; set; }

        [ForeignKey("Tag")]
        public int TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
