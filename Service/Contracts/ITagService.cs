using Domain.Entities;

namespace Service.Contracts
{
    public interface ITagService
    {
        Tag Find(int TagId);
        void AddTag(Tag Tag);
        void UpdateTag(Tag Tag);
        void DeleteTag(Tag Tag);
        void DeleteTag(int TagId);
        IList<Tag> GetAllTags();
        Tag GetTagByUrlSlug(string UrlSlug);
    }
}
