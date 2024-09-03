using Carter;
using GroceryPro.Api.Common.Extensions;
using GroceryPro.Api.Common.Models;
using GroceryPro.Api.Features.Products.GetProduct;
using MediatR;

namespace GroceryPro.Api.Features.Products.CreateProduct
{
    public class CreateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("api/v1/products", async (CreateProductRequest request, ISender sender) =>
            {
                var command = new CreateProductCommand(
                    request.ProductName,
                    request.Description,
                    request.Price,
                    request.StockQuantity,
                    request.CategoryId);

                var result = await sender.Send(command);

                var response = result.Value as ProductResponse;

                var uri = $"/api/v1/products/{response?.ProductId}";

                return result.Match(
                    onSuccess: () => Results.Created(uri, result.Value),
                    onFailure: error =>
                    {

                        return result.ErrorType switch
                        {
                            ErrorType.Conflict => Results.NotFound(error),
                            _ => Results.StatusCode(StatusCodes.Status500InternalServerError)
                        };
                    });

                //return result.IsSuccess ? Results.Created(uri, result.Value) : result.ToProblemDetails();


            })
                .Produces(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithTags("Products");
        }
    }
}
