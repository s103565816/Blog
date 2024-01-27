using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure
{
    public static class Initializer
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Technology", UrlSlug = "technology", Description = "All about technology" },
                new Category { CategoryId = 2, CategoryName = "Travel", UrlSlug = "travel", Description = "Travel experiences and guides" },
                new Category { CategoryId = 3, CategoryName = "Food", UrlSlug = "food", Description = "Delicious food and recipes" }
                );

            builder.Entity<Post>().HasData(
                new Post { PostId = 1, Title = "The Future of Tech", UrlSlug = "future-tech", Published = true, PostContent = "A very interesting post", DatePublished = DateTime.Now, CategoryId = 1 }, // Specify CategoryId
                new Post { PostId = 2, Title = "Top Travel Destinations", UrlSlug = "travel-destinations", Published = true, PostContent = "A very interesting post", DatePublished = DateTime.Now, CategoryId = 2 },
                new Post { PostId = 3, Title = "Best Street Foods", UrlSlug = "street-foods", Published = true, PostContent = "A very interesting post", DatePublished = DateTime.Now, CategoryId = 3 }
                );
            

            builder.Entity<Tag>().HasData(
                new Tag { TagId = 1 ,TagName = "Innovation", UrlSlug = "innovation", Description = "Innovative ideas and products", Count = 10 },
                new Tag { TagId = 2, TagName = "Adventure", UrlSlug = "adventure", Description = "Adventurous activities", Count = 5 },
                new Tag { TagId = 3, TagName = "Cuisine", UrlSlug = "cuisine", Description = "Various cuisines around the world", Count = 8 }
                );

            builder.Entity<PostTag>().HasData(
                new PostTag { PostId = 1, TagId = 1 },
                new PostTag { PostId = 2, TagId = 2 },
                new PostTag { PostId = 3, TagId = 3 }
                );
        }
    }
}
