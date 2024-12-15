using Mapster;
using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
using VerticalSliceArchitecture.src.Infrastructure.Data;
namespace VerticalSliceArchitecture.src.Feature.Product.Command.UpdateProduct;
public class UpdateProductCommandHandler(AppDbContext _context) : IRequestHandler<UpdateProductCommand, ServiceResponse>
{
    public async Task<ServiceResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = request.Product.Adapt<Domain.Entities.Product>();

        _context.Products.Update(product);

        await _context.SaveChangesAsync(cancellationToken);

        return new ServiceResponse(true, "Product updated successfully");
    }
}
