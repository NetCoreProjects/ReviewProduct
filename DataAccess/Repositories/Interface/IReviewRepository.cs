using DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interface
{
    public interface IReviewRepository
    {
        List<ReviewModel> GetReviewsByProductId(int productId);

        Task AddReview(ReviewModel review);

    }
}
