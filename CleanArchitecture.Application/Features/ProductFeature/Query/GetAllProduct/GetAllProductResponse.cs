using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.ProductFeature.Query.GetAllProduct
{
    public class GetAllProductResponse
    {
        public IList<Product> Products { get; set; }
    }
}
