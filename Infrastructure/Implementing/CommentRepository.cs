using Domain.Contracts;
using Domain.Entities;

namespace Infrastructure.Implementing
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BlogDbContext dbContext) : base(dbContext)
        {

        }
    }
    //public class CommentRepository : ICommentRepository
    //{
    //    private readonly BlogDbContext _context;

    //    public CommentRepository(BlogDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public Comment Find(int commentId)
    //    {
    //        return _context.Comments.Find(commentId);
    //    }

    //    public void AddComment(Comment comment)
    //    {
    //        _context.Comments.Add(comment);
    //        _context.SaveChanges();
    //    }

    //    public void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
    //    {
    //        var post = _context.Posts.Find(postId);

    //        if (post != null)
    //        {
    //            var comment = new Comment
    //            {
    //                Name = commentName,
    //                Email = commentEmail,
    //                PostId = postId,
    //                Post = post,
    //                CommentHeader = commentTitle,
    //                CommentText = commentBody,
    //                CommentTime = DateTime.Now
    //            };

    //            _context.Comments.Add(comment);
    //            _context.SaveChanges();
    //        }
    //    }

    //    public void UpdateComment(Comment comment)
    //    {
    //        _context.Comments.Update(comment);
    //        _context.SaveChanges();
    //    }

    //    public void DeleteComment(Comment comment)
    //    {
    //        _context.Comments.Remove(comment);
    //        _context.SaveChanges();
    //    }

    //    public void DeleteComment(int commentId)
    //    {
    //        var comment = _context.Comments.Find(commentId);
    //        if (comment != null)
    //        {
    //            _context.Comments.Remove(comment);
    //            _context.SaveChanges();
    //        }
    //    }

    //    public IList<Comment> GetAllComments()
    //    {
    //        return _context.Comments.ToList();
    //    }

    //    public IList<Comment> GetCommentsForPost(int postId)
    //    {
    //        return _context.Comments.Where(c => c.PostId == postId).ToList();
    //    }

    //    public IList<Comment> GetCommentsForPost(Post post)
    //    {
    //        return _context.Comments.Where(c => c.Post == post).ToList();
    //    }
    //}
}
