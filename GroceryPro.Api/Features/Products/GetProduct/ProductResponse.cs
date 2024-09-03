using GroceryPro.Api.Features.Categories.GetCategory;

namespace GroceryPro.Api.Features.Products.GetProduct
{
    public record ProductResponse(
        Guid ProductId, 
        string ProductName,
        string Description,
        decimal Price,
        int StockQuantity,
        CategoryResponse Category);

}
