using MediatR;
using VerticalSliceArchitecture.src.Feature.Category.Command.CreateCategory;
using VerticalSliceArchitecture.src.Feature.Category.Queries.GetAllCategory;

namespace VerticalSliceArchitecture.src.Feature.Category
{
    public static class CategoryEndpoints
    {
        public static IEndpointConventionBuilder MapCategoryEndpoint(this IEndpointRouteBuilder endpoint)
        {
            var categoryGroup = endpoint.MapGroup("/category");

            categoryGroup.MapPost("/create", async (CreateCategoryRequest category, ISender send) =>
            {
                var response = await send.Send(new CreateCategoryCommand(category));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });

            categoryGroup.MapGet("/all", async ( ISender send) =>
            {
                var response = await send.Send(new GetAllCategoryQuery());
                return response != null ? Results.Ok(response) : Results.NotFound();
            });

            return null!;
        }
    }
}
