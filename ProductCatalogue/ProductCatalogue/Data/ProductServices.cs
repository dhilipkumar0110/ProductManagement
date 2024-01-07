using ProductCatalogue.DataBaseContext;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalogue.Data
{
    public class ProductServices
    {
        private readonly ApplicationDBContext _dbContext;
        public ProductServices(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;

        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await _dbContext.ProductDetails.ToListAsync();
        }

        public async Task<bool> AddNewProduct(Products category)
        {
            await _dbContext.ProductDetails.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Products> GetProductByID(int categoryId)
        {
            Products category = await _dbContext.ProductDetails.FirstOrDefaultAsync(x => x.ProductId == categoryId);

            return category;
        }

        public async Task<bool> UpdateProductDetails(Products category)
        {
            _dbContext.ProductDetails.Update(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductDetails(Products category)
        {
            _dbContext.ProductDetails.Remove(category);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
