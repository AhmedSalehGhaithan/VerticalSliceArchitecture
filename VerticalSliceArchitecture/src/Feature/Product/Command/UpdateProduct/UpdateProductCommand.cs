using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
namespace VerticalSliceArchitecture.src.Feature.Product.Command.UpdateProduct;

public record UpdateProductCommand(UpdateProductRequest Product) : IRequest<ServiceResponse>
{
}
