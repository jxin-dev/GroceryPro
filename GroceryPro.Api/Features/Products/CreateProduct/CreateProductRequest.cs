namespace GroceryPro.Api.Features.Products.CreateProduct
{
    public record CreateProductRequest(
        string ProductName,
        string Description,
        decimal Price,
        int StockQuantity,
        Guid CategoryId);
}
