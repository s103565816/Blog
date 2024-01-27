using Domain.Entities;

namespace Service.Contracts
{
    public interface ICategoryService
    {
        Category Find(int categoryId);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void DeleteCategory(int categoryId);
        IList<Category> GetAllCategories();
    }
}
