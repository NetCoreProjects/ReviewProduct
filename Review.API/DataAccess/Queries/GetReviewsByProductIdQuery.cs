using MediatR;
using Review.API.Common;
using Review.API.Model;
using Review.API.Repository;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Review.API.DataAccess.Queries
{
    public class GetReviewsByProductIdQuery : IRequest<RequestResult<IEnumerable<ReviewModel>>>
    {
        public int ProductId { get; set; }

        public class Handler : IRequestHandler<GetReviewsByProductIdQuery, RequestResult<IEnumerable<ReviewModel>>>
        {
            private readonly IReviewRepository _reviewRepository;
            public Handler(IReviewRepository reviewRepository)
            {
                _reviewRepository = reviewRepository ?? throw new ArgumentNullException(nameof(reviewRepository));
            }


            public async Task<RequestResult<IEnumerable<ReviewModel>>> Handle(GetReviewsByProductIdQuery request, CancellationToken cancellationToken)
            {
                if(request == null || request.ProductId <= 0)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var result = await _reviewRepository.GetReviewsByProductId(request.ProductId).ConfigureAwait(false);
                return RequestResult.Success(result);
            }
        }
    }
}
