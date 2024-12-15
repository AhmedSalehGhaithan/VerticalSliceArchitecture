using MediatR;

namespace VerticalSliceArchitecture.src.Feature.Category.Queries.GetAllCategory;

public record GetAllCategoryQuery : IRequest<IEnumerable<GetCategoryResponse>>
{
}

