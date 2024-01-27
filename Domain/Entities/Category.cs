using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = string.Empty;

        [Required]
        public string UrlSlug { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public List<Post>? Posts { get; set; }
    }
}
