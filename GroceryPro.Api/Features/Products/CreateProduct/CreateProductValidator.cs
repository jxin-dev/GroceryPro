using MediatR.Pipeline;

namespace GroceryPro.Api.Features.Products.CreateProduct
{
    public class CreateProductValidator : IRequestPreProcessor<CreateProductCommand>
    {
        public Task Process(CreateProductCommand request, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }
    }
}
