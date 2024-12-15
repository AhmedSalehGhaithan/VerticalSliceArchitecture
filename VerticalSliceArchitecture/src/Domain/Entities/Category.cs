namespace VerticalSliceArchitecture.src.Domain.Entities;
public class Category : BaseEntity
{
    public ICollection<Product>? Products { get; set; }
}
