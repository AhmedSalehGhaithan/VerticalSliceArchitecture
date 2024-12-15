using MediatR;
namespace VerticalSliceArchitecture.src.Feature.Product.Queries.GetAllProduct;
public record GetAllProductQuery : IRequest<IEnumerable<GetProductResponse>>
{
}
