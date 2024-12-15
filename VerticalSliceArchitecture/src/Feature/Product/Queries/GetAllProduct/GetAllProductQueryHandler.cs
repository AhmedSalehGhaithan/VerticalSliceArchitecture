using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.src.Infrastructure.Data;
namespace VerticalSliceArchitecture.src.Feature.Product.Queries.GetAllProduct;

public record GetAllProductQueryHandler(AppDbContext _context) : IRequestHandler<GetAllProductQuery, IEnumerable<GetProductResponse>>
{
    public async Task<IEnumerable<GetProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var products = await _context.Products.Include(c => c.Category).AsNoTracking().ToListAsync(cancellationToken);
        return products.Adapt<IEnumerable<GetProductResponse>>();
    }
}
