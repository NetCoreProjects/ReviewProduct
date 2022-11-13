using Review.API.Model;

namespace Review.API.DataAccess.Command
{
    public partial class ReviewForProductModel
    {
        public int ProductId { get; set; }
        public ScoreValues Score { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool IsRecommended { get; set; }

        public ReviewModel ToReviewModel()
        {
            return new ReviewModel
            {
                ProductId = this.ProductId,
                Score = (int)this.Score,
                Title = this.Title,
                Comment = this.Comment,
                IsRecommended = this.IsRecommended
            };
        }
    }
}
