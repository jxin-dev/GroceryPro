using GroceryPro.Api.Features.Products.GetProduct;
using MediatR;

namespace GroceryPro.Api.Features.Products.GetAllProducts
{
    public record GetAllProductsQuery : IRequest<IEnumerable<ProductResponse>>;
}
