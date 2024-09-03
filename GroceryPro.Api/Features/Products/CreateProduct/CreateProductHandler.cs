using GroceryPro.Api.Common.Models;
using GroceryPro.Api.Database;
using GroceryPro.Api.Entities;
using GroceryPro.Api.Features.Products.GetProduct;
using Mapster;
using MediatR;

namespace GroceryPro.Api.Features.Products.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Result>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateProductHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new()
            {
                ProductId = Guid.NewGuid(),
                ProductName = request.ProductName,
                Description = request.Description,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                CategoryId = request.CategoryId
            };

            await _dbContext.Products.AddAsync(product);

            var response = product.Adapt<ProductResponse>();

            return Result.Failure(ProductErrors.Notfound(product.ProductId), ErrorType.Notfound);

            //return Result.Success(response);
        }
    }
}
