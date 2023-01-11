using CleanArchitecture.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.ProductFeature.Query.GetAllProduct
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductRequest, GetAllProductResponse>
    {
        private readonly IProductService _productService;

        public GetAllProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetAllProductResponse> Handle(GetAllProductRequest request, CancellationToken cancellationToken)
        {
            return new GetAllProductResponse { Products = _productService.GetAll().ToList() };
        }
    }
}
