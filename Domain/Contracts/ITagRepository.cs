using Domain.Entities;

namespace Domain.Contracts
{
    //public interface ITagRepository
    //{
    //    Tag Find(int TagId);
    //    void AddTag(Tag Tag);
    //    void UpdateTag(Tag Tag);
    //    void DeleteTag(Tag Tag);
    //    void DeleteTag(int TagId);
    //    IList<Tag> GetAllTags();
    //    Tag GetTagByUrlSlug(string UrlSlug);
    //}

    public interface ITagRepository : IGenericRepository<Tag>
    {

    }
}
