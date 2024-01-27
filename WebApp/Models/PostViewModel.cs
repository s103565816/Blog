using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class PostViewModel
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string ShortDescription { get; set; } = string.Empty;

        public string PostContent { get; set; } = string.Empty;

        [Required]
        public string UrlSlug { get; set; } = string.Empty;

        [Required]
        public bool Published { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        public DateTime Modified { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<PostTag> PostTags { get; set; }

        public int ViewCount { get; set; }

        public int RateCount { get; set; }

        public int TotalRate { get; set; }

        [NotMapped]
        public decimal Rate
        {
            get
            {
                return RateCount > 0 ? (decimal)TotalRate / RateCount : 0;
            }
        }

        public ICollection<Comment> Comments { get; set; }
    }
}
