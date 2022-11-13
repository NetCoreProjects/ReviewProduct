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
        private BeerReviewDbContext _dbContext;
        public ProductRepository(BeerReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddProductAsync(ProductModel product)
        {
            if(product != null)
            {
                await _dbContext.Product.AddAsync(product).ConfigureAwait(false);
            }
        }

        public void UpdateProduct(ProductModel product)
        {
            if (product != null && product.Id > 0)
            {
                _dbContext.Product.Update(product);
            }
        }

        public List<ProductModel> GetAllProducts()
        {
            return _dbContext.Product.ToList();
        }

        public ProductModel GetProductById(int productId)
        {
            if(productId > 0)
            {
                return _dbContext.Product.First(t => t.Id == productId);
            }
            return null;
        }
    }
}
