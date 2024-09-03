using Carter;
using MediatR;

namespace GroceryPro.Api.Features.Products.GetAllProducts
{
    public class GetAllProductsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/products/", async (ISender sender) =>
            {
                var query = new GetAllProductsQuery();
                var result = await sender.Send(query);

                return Results.Ok(result);
            })
                .Produces(StatusCodes.Status200OK)
                .WithTags("Products");
        }
    }
}
