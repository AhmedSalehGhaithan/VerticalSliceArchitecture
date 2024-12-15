using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
namespace VerticalSliceArchitecture.src.Feature.Product.Command.DeleteProduct;
public record DeleteProductCommand(Guid id) : IRequest<ServiceResponse>
{
}
