using GroceryPro.Api.Common.Models;

namespace GroceryPro.Api.Features.Products
{
    public static class ProductErrors
    {
        public static Error Notfound(Guid productId)
        {
            return new Error("Product.Notfound", $"The product with the Id = {productId} was not found.");
        }
    }
}
