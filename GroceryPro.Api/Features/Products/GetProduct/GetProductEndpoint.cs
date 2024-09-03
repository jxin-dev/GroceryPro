using Carter;
using MediatR;

namespace GroceryPro.Api.Features.Products.GetProduct
{
    public class GetProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/products/{id}", async (Guid id, ISender sender) =>
            {
                var query = new GetProductQuery(id);
                var result = await sender.Send(query);

                return Results.Ok(result);
            })
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status200OK)
                .WithTags("Products");
        }
    }
}
