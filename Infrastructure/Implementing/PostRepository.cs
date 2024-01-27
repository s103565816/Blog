using Domain.Contracts;
using Domain.Entities;

namespace Infrastructure.Implementing
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogDbContext context) : base(context)
        {

        }
    }
    //public class PostRepository : IPostRepository
    //{
    //    private readonly BlogDbContext _context;

    //    public PostRepository(BlogDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public Post FindPost(int year, int month, string urlSlug)
    //    {
    //        return _context.Posts.FirstOrDefault(p => p.DatePublished.Year == year &&
    //                                                  p.DatePublished.Month == month &&
    //                                                  p.UrlSlug == urlSlug);
    //    }

    //    public Post FindPost(int postId)
    //    {
    //        return _context.Posts.Find(postId);
    //    }

    //    public void AddPost(Post post)
    //    {
    //        _context.Posts.Add(post);
    //        _context.SaveChanges();
    //    }

    //    public void UpdatePost(Post post)
    //    {
    //        _context.Posts.Update(post);
    //        _context.SaveChanges();
    //    }

    //    public void DeletePost(Post post)
    //    {
    //        _context.Posts.Remove(post);
    //        _context.SaveChanges();
    //    }

    //    public void DeletePost(int postId)
    //    {
    //        var post = _context.Posts.Find(postId);
    //        if (post != null)
    //        {
    //            _context.Posts.Remove(post);
    //            _context.SaveChanges();
    //        }
    //    }

    //    public IList<Post> GetAllPosts()
    //    {
    //        return _context.Posts.ToList();
    //    }

    //    public IList<Post> GetPublishedPosts()
    //    {
    //        return _context.Posts.Where(p => p.Published).ToList();
    //    }

    //    public IList<Post> GetUnpublishedPosts()
    //    {
    //        return _context.Posts.Where(p => !p.Published).ToList();
    //    }

    //    public IList<Post> GetLatestPost(int size)
    //    {
    //        return _context.Posts.OrderByDescending(p => p.DatePublished).Take(size).ToList();
    //    }

    //    public IList<Post> GetPostsByMonth(DateTime monthYear)
    //    {
    //        return _context.Posts.Where(p => p.DatePublished.Year == monthYear.Year &&
    //                                         p.DatePublished.Month == monthYear.Month).ToList();
    //    }

    //    public int CountPostsForCategory(string category)
    //    {
    //        return _context.Posts.Count(p => p.Category.CategoryName == category);
    //    }

    //    public IList<Post> GetPostsByCategory(string category)
    //    {
    //        return _context.Posts.Where(p => p.Category.CategoryName == category).ToList();
    //    }

    //    public int CountPostsForTag(string tag)
    //    {
    //        return _context.Posts.Count(p => p.PostTags.Any(t => t.Tag.TagName == tag));
    //    }

    //    public IList<Post> GetPostsByTag(string tag)
    //    {
    //        return _context.Posts.Where(p => p.PostTags.Any(t => t.Tag.TagName == tag)).ToList();
    //    }
    //    public IList<Post> GetMostViewedPost(int size)
    //    {
    //        return _context.Posts.OrderByDescending(p => p.ViewCount).Take(size).ToList();
    //    }

    //    public IList<Post> GetHighestPosts(int size)
    //    {
    //        return _context.Posts.OrderByDescending(p => p.Rate).Take(size).ToList();
    //    }
    //}
}
