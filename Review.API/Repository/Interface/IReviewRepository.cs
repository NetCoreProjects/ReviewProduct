using Review.API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Review.API.Repository
{
    public interface IReviewRepository
    {
        Task<IEnumerable<ReviewModel>> GetReviewsByProductId(int productId);

        Task AddReviewAsync(ReviewModel review);

    }
}
