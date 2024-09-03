using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GroceryPro.Api.Features.Categories.CreateCategory
{
    public class CreateCategoryEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/v1/products/categories/", async ([FromBody] CreateCategoryRequest request, ISender sender) =>
            {
                var command = new CreateCategoryCommand(request.CategoryName);
                var result = await sender.Send(command);
                return Results.Ok();
            })
                .Produces(StatusCodes.Status201Created)
                .WithTags("Categories");
        }
    }
}
