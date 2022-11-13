using Review.API.DatabaseConfigurations;
using Review.API.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Class
{
    public class ReviewRepository : IReviewRepository
    {
        private BeerReviewDbContext _dbContext;
        public ReviewRepository(BeerReviewDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddReview(ReviewModel review)
        {
            await _dbContext.Review.AddAsync(review).ConfigureAwait(false);
            await _dbContext.SaveChangesAsync();
        }

        public List<ReviewModel> GetReviewsByProductId(int productId)
        {
            return _dbContext.Review.Where(t => t.ProductId == productId).ToList();
        }
    }
}
