namespace VerticalSliceArchitecture.src.Domain.Entities;
public class Product : BaseEntity
{
    public decimal Price { get; set; } 
    public Category? Category { get; set; } 
    public Guid CategoryId { get; set; }
}
