using MediatR.Pipeline;

namespace GroceryPro.Api.Features.Categories.CreateCategory
{
    public class CreateCategoryValidator : IRequestPreProcessor<CreateCategoryCommand>
    {
        public Task Process(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            
            throw new NotImplementedException();
        }
    }
}
