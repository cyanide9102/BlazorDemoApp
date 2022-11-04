namespace BlazorDemoApp.SharedKernel.Dtos;
public class ProductReadDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public BrandReadDto Brand { get; set; }
    public CategoryReadDto Category { get; set; }
}
