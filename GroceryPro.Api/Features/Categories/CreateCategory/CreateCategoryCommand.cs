using GroceryPro.Api.Features.Categories.GetCategory;
using MediatR;

namespace GroceryPro.Api.Features.Categories.CreateCategory
{
    public record CreateCategoryCommand(string CategoryName) : IRequest<CategoryResponse>;
}
