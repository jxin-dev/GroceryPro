using GroceryPro.Api.Database;
using GroceryPro.Api.Features.Products.GetProduct;
using MediatR;

namespace GroceryPro.Api.Features.Products.GetAllProducts
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductResponse>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAllProductsHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<ProductResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
