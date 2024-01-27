using Domain.Contracts;
using Domain.Entities;

namespace Infrastructure.Implementing
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(BlogDbContext dbContext) : base(dbContext)
        {

        }
    }
    //public class TagRepository : ITagRepository
    //{
    //    private readonly BlogDbContext _context;

    //    public TagRepository(BlogDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public Tag Find(int tagId)
    //    {
    //        return _context.Tags.FirstOrDefault(t => t.TagId == tagId);
    //    }

    //    public void AddTag(Tag tag)
    //    {
    //        _context.Tags.Add(tag);
    //        _context.SaveChanges();
    //    }

    //    public void UpdateTag(Tag tag)
    //    {
    //        _context.Tags.Update(tag);
    //        _context.SaveChanges();
    //    }

    //    public void DeleteTag(Tag tag)
    //    {
    //        _context.Tags.Remove(tag);
    //        _context.SaveChanges();
    //    }

    //    public void DeleteTag(int tagId)
    //    {
    //        var tag = _context.Tags.Find(tagId);

    //        if (tag != null)
    //        {
    //            _context.Tags.Remove(tag);
    //            _context.SaveChanges();
    //        }
    //    }

    //    public IList<Tag> GetAllTags()
    //    {
    //        return _context.Tags.ToList();
    //    }

    //    public Tag GetTagByUrlSlug(string urlSlug)
    //    {
    //        return _context.Tags.FirstOrDefault(t => t.UrlSlug == urlSlug);
    //    }
    //}
}
