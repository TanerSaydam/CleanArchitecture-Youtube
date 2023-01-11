using CleanArchitecture.Application.Features.ProductFeature.Command.CreateProduct;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistance.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(CreateProductRequest request)
        {
            Product product = new()
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Set<Product>().AsQueryable();
        }
    }
}
