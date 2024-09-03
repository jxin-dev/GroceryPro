using MediatR;

namespace GroceryPro.Api.Features.Products.GetProduct
{
    public record GetProductQuery(Guid ProductId) : IRequest<ProductResponse>;
}
