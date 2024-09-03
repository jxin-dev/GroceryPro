using GroceryPro.Api.Database;
using GroceryPro.Api.Features.Categories.GetCategory;
using MediatR;

namespace GroceryPro.Api.Features.Categories.CreateCategory
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, CategoryResponse>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateCategoryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<CategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
