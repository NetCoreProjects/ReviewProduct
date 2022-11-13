using MediatR;
using Review.API.Common;
using Review.API.Model;
using Review.API.Repository.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Review.API.DataAccess.Queries
{
    public class GetProductByIdQuery : IRequest<RequestResult<ProductModel>>
    {
        public int ProductId { get; set; }

        public class Handler : IRequestHandler<GetProductByIdQuery, RequestResult<ProductModel>>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            }

            public async Task<RequestResult<ProductModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                if (request == null || request.ProductId <= 0)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var result = await _productRepository.GetProductByIdAsync(request.ProductId).ConfigureAwait(false);

                return RequestResult.Success(result);
            }
        }
    }
}
