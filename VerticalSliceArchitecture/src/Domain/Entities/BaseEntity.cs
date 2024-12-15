namespace VerticalSliceArchitecture.src.Domain.Entities;
public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
}
