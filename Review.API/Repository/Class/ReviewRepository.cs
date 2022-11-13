using Review.API.DatabaseConfigurations;
using Review.API.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review.API.Repository.Class
{
    public class ReviewRepository : IReviewRepository
    {
        private RevewProductDbContext _dbContext;
        public ReviewRepository(RevewProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddReviewAsync(ReviewModel review)
        {
            if(review != null)
            {
                await _dbContext.Review.AddAsync(review).ConfigureAwait(false);
                await _dbContext.SaveChangesAsync();
            }
            
        }

        public Task<IEnumerable<ReviewModel>> GetReviewsByProductId(int productId)
        {
            return Task.FromResult(_dbContext.Review.Where(t => t.ProductId == productId).AsEnumerable());
        }
    }
}
