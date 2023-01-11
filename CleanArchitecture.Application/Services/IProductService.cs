using CleanArchitecture.Application.Features.ProductFeature.Command.CreateProduct;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IProductService
    {
        Task Create(CreateProductRequest request);
        IQueryable<Product> GetAll();
    }
}
