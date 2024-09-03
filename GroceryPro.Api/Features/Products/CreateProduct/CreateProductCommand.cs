using GroceryPro.Api.Common.Models;
using GroceryPro.Api.Features.Products.GetProduct;
using MediatR;

namespace GroceryPro.Api.Features.Products.CreateProduct
{
    public record CreateProductCommand(
        string ProductName, 
        string Description, 
        decimal Price,
        int StockQuantity,
        Guid CategoryId) : IRequest<Result>;

}
