namespace Shlykovich.Services
{
    public class MemoryCategoryService : ICategoryService
    {
        public Task<ResponseData<List<Category>>> GetCategoryListAsync()
        {
            var categories = new List<Category>
        {
            new Category {Id=1, Name="Стартеры",NormalizedName="starters"},
     
            new Category {Id=2, Name="Салаты",NormalizedName="salads"},
        };
            var result = new ResponseData<List<Category>>();
            result.Data = categories;
            return Task.FromResult(result);
        }
    }

}
