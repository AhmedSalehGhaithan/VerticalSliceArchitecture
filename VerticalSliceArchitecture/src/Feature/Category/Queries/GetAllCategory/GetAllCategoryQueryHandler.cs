using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.src.Infrastructure.Data;

namespace VerticalSliceArchitecture.src.Feature.Category.Queries.GetAllCategory;

public class GetAllCategoryQueryHandler(AppDbContext _context) :
    IRequestHandler<GetAllCategoryQuery, IEnumerable<GetCategoryResponse>>
{
    public async Task<IEnumerable<GetCategoryResponse>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        var categories = await _context.categories.AsNoTracking().ToListAsync(cancellationToken);

        return categories.Adapt<IEnumerable<GetCategoryResponse>>();
    }
}

