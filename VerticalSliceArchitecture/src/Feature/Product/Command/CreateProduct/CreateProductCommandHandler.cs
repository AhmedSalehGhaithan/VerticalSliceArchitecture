using Mapster;
using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
using VerticalSliceArchitecture.src.Infrastructure.Data;
namespace VerticalSliceArchitecture.src.Feature.Product.Command.CreateProduct;
public class CreateProductCommandHandler(AppDbContext _context)
    : IRequestHandler<CreateProductCommand, ServiceResponse>
{
    public async Task<ServiceResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = request.Product.Adapt<Domain.Entities.Product>();
        _context.Products.Add(product);
        await _context.SaveChangesAsync(cancellationToken);
        return new ServiceResponse(true, "Product added Successfully.");
    }
}
