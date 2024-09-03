using GroceryPro.Api.Database;
using GroceryPro.Api.Features.Categories.GetCategory;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GroceryPro.Api.Features.Products.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, ProductResponse>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProductHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products
                .Include(product => product.Category)
                .FirstOrDefaultAsync(product => product.ProductId == request.ProductId);

            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            return new ProductResponse(
                product.ProductId,
                product.ProductName,
                product.Description,
                product.Price,
                product.StockQuantity,
                new CategoryResponse(product.Category.CategoryId, product.Category.CategoryName));
        }   
    }
}
