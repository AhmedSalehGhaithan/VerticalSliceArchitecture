using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
using VerticalSliceArchitecture.src.Infrastructure.Data;
namespace VerticalSliceArchitecture.src.Feature.Product.Command.DeleteProduct;
public class DeleteProductCommandHandler(AppDbContext _context) : IRequestHandler<DeleteProductCommand, ServiceResponse>
{
    public async Task<ServiceResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _context.Products.FindAsync(request.id);

        _context.Products.Remove(product!);

        await _context.SaveChangesAsync(cancellationToken);

        return new ServiceResponse(true, "Product Deleted Successfully");
    }
}
