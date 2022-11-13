using Review.API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Review.API.Repository.Interface
{
    public interface IProductRepository
    {
        Task<ProductModel> GetProductByIdAsync(int productId);

        Task<IEnumerable<ProductModel>> GetAllProductsAsync(); 

        Task AddProductAsync(ProductModel product);

        void UpdateProduct(ProductModel product);
    }
}
