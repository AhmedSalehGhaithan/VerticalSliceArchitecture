using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
namespace VerticalSliceArchitecture.src.Feature.Product.Command.CreateProduct;
public record CreateProductCommand(CreateProductRequest Product) : IRequest<ServiceResponse>
{
}
