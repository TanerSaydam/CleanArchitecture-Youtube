using CleanArchitecture.Application.Features.ProductFeature.Command.CreateProduct;
using CleanArchitecture.Application.Features.ProductFeature.Query.GetAllProduct;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest request)
        {
            CreateProductResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            GetAllProductRequest request = new();
            GetAllProductResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
