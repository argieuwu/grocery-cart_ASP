namespace SuperMarket.Models
{
    public class CategoriesRepositoryModel
    {
        private static List<CategoryModel> _categories = new List<CategoryModel>()
        {
            new CategoryModel {CategoryId = 1, Name = "ratatowe", Description = "bombay"},
    
        };

        public static void AddCategory (CategoryModel category)
        {
            var maxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        public static List<CategoryModel> GetCategoryModels() => _categories;

        public static CategoryModel? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if(category != null)
            {
                return new CategoryModel
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            return null;
        }

        public static void UpdateCategory(int categoryId, CategoryModel category)
        {
            if (categoryId != category.CategoryId) return;

            var categoryToUpdate = GetCategoryById(categoryId);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Description;
                categoryToUpdate.Description = category.Description;
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);

            if (category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}
