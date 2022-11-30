namespace FarmersMarketAPI.Services.Interfaces
{
    using FarmersMarketAPI.Models.BindingModels;
    using FarmersMarketAPI.Models.ViewModels;

    public interface ICategoriesService
    {
        IEnumerable<CategoryViewModel> GetAllCategories();
        IEnumerable<CategoryViewModel> GetActiveCategories();
        void CreateNewCategory(CategoryBindingModel model);
        CategoryViewModel? GetEditCategory(int? id);
        void EditCategory(CategoryBindingModel model);
        CategoryViewModel? GetDeleteCategory(int? id);
        void DeleteCategory(int id);
    }
}
