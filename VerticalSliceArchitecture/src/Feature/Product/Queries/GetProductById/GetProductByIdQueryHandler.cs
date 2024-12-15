using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.src.Infrastructure.Data;
namespace VerticalSliceArchitecture.src.Feature.Product.Queries.GetProductById;

public class GetProductByIdQueryHandler(AppDbContext _context) : IRequestHandler<GetProductByIdQuery, GetProductResponse>
{
    public async Task<GetProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var products =
            await _context.Products
            .Include(c => c.Category).FirstOrDefaultAsync(p => p.Id == request.id, cancellationToken);

        return products.Adapt<GetProductResponse>();
    }
}