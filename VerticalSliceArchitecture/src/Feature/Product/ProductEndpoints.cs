using MediatR;
using VerticalSliceArchitecture.src.Feature.Product.Command.CreateProduct;
using VerticalSliceArchitecture.src.Feature.Product.Command.DeleteProduct;
using VerticalSliceArchitecture.src.Feature.Product.Command.UpdateProduct;
using VerticalSliceArchitecture.src.Feature.Product.Queries.GetAllProduct;
using VerticalSliceArchitecture.src.Feature.Product.Queries.GetProductById;
namespace VerticalSliceArchitecture.src.Feature.Product;
public static class ProductEndpoints
{
    public static IEndpointConventionBuilder MapProductEndpoints(this IEndpointRouteBuilder endpoint)
    {
        var productGroup = endpoint.MapGroup("/product");

        productGroup.MapPost("/create", async (CreateProductRequest product, ISender send) =>
        {
            var response = await send.Send(new CreateProductCommand(product));
            return response.Success ? Results.Ok(response) : Results.BadRequest(response);
        });

        productGroup.MapPut("/update", async (UpdateProductRequest product, ISender send) =>
        {
            var response = await send.Send(new UpdateProductCommand(product));
            return response.Success ? Results.Ok(response) : Results.BadRequest(response);
        });

        productGroup.MapDelete("/delete/{id}", async (Guid id, ISender send) =>
        {
            var response = await send.Send(new DeleteProductCommand(id));
            return response.Success ? Results.Ok(response) : Results.BadRequest(response);
        });

        productGroup.MapGet("/getById/{id}", async (string id, ISender send) =>
        {
            if (!Guid.TryParse(id, out var guid))
            {
                return Results.BadRequest("Invalid GUID format.");
            }

            var response = await send.Send(new GetProductByIdQuery(guid));
            return response != null ? Results.Ok(response) : Results.NotFound();
        });



        productGroup.MapGet("/getAll", async ( ISender send) =>
        {
            var response = await send.Send(new GetAllProductQuery());
            return response != null ? Results.Ok(response) : Results.NotFound();
        });

        return productGroup;
    }
}
