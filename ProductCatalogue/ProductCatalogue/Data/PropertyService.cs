using ProductCatalogue.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalogue.Data
{
    public class PropertyService
    {
        private readonly ApplicationDBContext _dbContext;
        public PropertyService(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

        public async Task<List<ProductProperties>> GetAllProperties()
        {
            return await _dbContext.PropertyDetails.ToListAsync();
        }

        public async Task<bool> AddNewProperty(ProductProperties category)
        {
            await _dbContext.PropertyDetails.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<ProductProperties> GetPropertyByID(int categoryId)
        {
            ProductProperties category = await _dbContext.PropertyDetails.FirstOrDefaultAsync(x => x.PropertyId == categoryId);

            return category;
        }

        public async Task<bool> UpdatePropertyDetails(ProductProperties category)
        {
            _dbContext.PropertyDetails.Update(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePropertyDetails(ProductProperties category)
        {
            _dbContext.PropertyDetails.Remove(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
