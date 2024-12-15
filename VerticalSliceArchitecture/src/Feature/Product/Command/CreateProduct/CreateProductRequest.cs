namespace VerticalSliceArchitecture.src.Feature.Product.Command.CreateProduct;
public class CreateProductRequest
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public Guid CategoryId { get; set; }
}
