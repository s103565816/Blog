using Service.Contracts;
using Infrastructure;
using Domain.Entities;
using Domain.Contracts;

namespace Service.Implementing
{
    public class CategoryService : ICategoryService
    {
        private readonly BlogDbContext _context;

        public IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public CategoryService(BlogDbContext context)
        {
            _context = context;
        }

        public Category Find(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _context.Categories.Find(categoryId);

            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public IList<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
