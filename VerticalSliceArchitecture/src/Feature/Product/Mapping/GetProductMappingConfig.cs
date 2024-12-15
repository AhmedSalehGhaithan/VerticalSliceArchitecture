using Mapster;
namespace VerticalSliceArchitecture.src.Feature.Product.Mapping;
public class GetProductMappingConfig
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Domain.Entities.Product, GetProductResponse>()
            .Map(d => d.CategoryName, s => s.Category!.Name);
    }
}
