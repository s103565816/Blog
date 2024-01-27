using Domain.Entities;

namespace Domain.Contracts
{
    //public interface ICategoryRepository
    //{
    //    Category Find(int categoryId);
    //    void AddCategory(Category category);
    //    void UpdateCategory(Category category);
    //    void DeleteCategory(Category category);
    //    void DeleteCategory(int categoryId);
    //    IList<Category> GetAllCategories();
    //}

    public interface ICategoryRepository : IGenericRepository<Category>
    {

    }
}
