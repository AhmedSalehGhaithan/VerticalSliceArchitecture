using Mapster;
using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;
using VerticalSliceArchitecture.src.Infrastructure.Data;

namespace VerticalSliceArchitecture.src.Feature.Category.Command.CreateCategory
{
    public class CreateCategoryCommandHandler(AppDbContext _context)
        : IRequestHandler<CreateCategoryCommand, ServiceResponse>
    {
        public async Task<ServiceResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = request._Category.Adapt<Domain.Entities.Category>();

            _context.categories.Add(category);

            await _context.SaveChangesAsync(cancellationToken);

            return new ServiceResponse(true, "Category created successfully");
        }
    }
}
