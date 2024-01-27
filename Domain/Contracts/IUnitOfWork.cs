namespace Domain.Contracts
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }

        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
