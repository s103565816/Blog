using Domain.Contracts;

namespace Infrastructure.Implementing
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext _dbContext;

        private readonly ICategoryRepository _categoryRepository;
        private readonly IPostRepository _postRepository;
        private readonly ITagRepository _tagRepository;
        private readonly ICommentRepository _commentRepository;

        public UnitOfWork(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_dbContext);
        public IPostRepository PostRepository => _postRepository ?? new PostRepository(_dbContext);
        public ITagRepository TagRepository => _tagRepository ?? new TagRepository(_dbContext);
        public ICommentRepository CommentRepository => _commentRepository ?? new CommentRepository(_dbContext);

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
