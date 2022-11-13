using MediatR;
using Review.API.Common;
using Review.API.Model;
using Review.API.Repository.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Review.API.DataAccess.Command
{
    public class AddProductCommand : IRequest<RequestResult<Unit>>
    {
        public ProductModel Product { get; set; }

        public class Handler : IRequestHandler<AddProductCommand, RequestResult<Unit>>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            }

            public async Task<RequestResult<Unit>> Handle(AddProductCommand request, CancellationToken cancellationToken)
            {
                if (request == null || request.Product == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                await _productRepository.AddProductAsync(request.Product).ConfigureAwait(false);

                return RequestResult.Success(Unit.Value);
            }
        }
    }
}
