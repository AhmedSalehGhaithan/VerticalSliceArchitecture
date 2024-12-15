using MediatR;
namespace VerticalSliceArchitecture.src.Feature.Product.Queries.GetProductById;
public record GetProductByIdQuery(Guid id) : IRequest<GetProductResponse>
{
}
