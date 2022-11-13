using Review.API.DatabaseConfigurations;
using Review.API.Model;
using Review.API.Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review.API.Repository.Class
{
    public class ProductRepository : IProductRepository
    {
        private RevewProductDbContext _dbContext;
        public ProductRepository(RevewProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddProductAsync(ProductModel product)
        {
            if(product != null)
            {
                await _dbContext.Product.AddAsync(product).ConfigureAwait(false);
                await _dbContext.SaveChangesAsync();
            }
        }

        public void UpdateProduct(ProductModel product)
        {
            if (product != null && product.Id > 0)
            {
                _dbContext.Product.Update(product);
            }
        }

        public Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return Task.FromResult(_dbContext.Product.AsEnumerable());
        }

        public Task<ProductModel> GetProductByIdAsync(int productId)
        {
            if(productId > 0)
            {
                return Task.FromResult(_dbContext.Product.First(t => t.Id == productId));
            }
            return null;
        }
    }
}
