namespace VerticalSliceArchitecture.src.Feature.Category
{
    public class GetCategoryResponse
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
    }
}
