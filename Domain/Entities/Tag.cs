using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        public string TagName { get; set; } = string.Empty;

        [Required]
        public string UrlSlug { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Count { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
