using MediatR;
using VerticalSliceArchitecture.src.Common.Shared;

namespace VerticalSliceArchitecture.src.Feature.Category.Command.CreateCategory
{
    public record CreateCategoryCommand(CreateCategoryRequest _Category)
        : IRequest<ServiceResponse>
    {

    }
}
