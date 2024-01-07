using Microsoft.EntityFrameworkCore;
using ProductCatalogue.DataBaseContext;

namespace ProductCatalogue.Data
{
	public class CategoryService
	{
		private readonly ApplicationDBContext _dbContext;
		public CategoryService(ApplicationDBContext applicationDBContext) 
		{
			_dbContext = applicationDBContext;
		
		}

		public async Task<List<Category>> GetAllCategories()
		{
			return await _dbContext.Categories.ToListAsync();
		}

		public async Task<bool> AddNewCategory(Category category)
		{
			await _dbContext.Categories.AddAsync(category);
			await _dbContext.SaveChangesAsync();
			return true;
		}

		public async Task<Category> GetCategoryByID(int categoryId)
		{
			Category category = await _dbContext.Categories.FirstOrDefaultAsync(x => x.Category_Id == categoryId);

			return category;
		}

		public async Task<bool> UpdateCategoryDetails(Category category)
		{
			_dbContext.Categories.Update(category);
			await _dbContext.SaveChangesAsync();
			return true;
		}

		public async Task<bool> DeleteCategoryDetails(Category category)
		{
			_dbContext.Categories.Remove(category);
			await _dbContext.SaveChangesAsync();
			return true;
		}
        public async Task<bool> GetCategoryID(Category category)
        {
            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
