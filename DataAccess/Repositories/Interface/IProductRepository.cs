using DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interface
{
    public interface IProductRepository
    {
        ProductModel GetProductById(int productId);

        List<ProductModel> GetAllProducts(); 

        Task AddProductAsync(ProductModel product);

        void UpdateProduct(ProductModel product);
    }
}
