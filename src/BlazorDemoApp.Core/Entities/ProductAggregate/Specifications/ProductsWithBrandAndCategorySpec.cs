using Ardalis.Specification;

using BlazorDemoApp.SharedKernel.Dtos;

namespace BlazorDemoApp.Core.Entities.ProductAggregate.Specifications;
public class ProductsWithBrandAndCategorySpec : Specification<Product, ProductReadDto>, ISingleResultSpecification
{
    public ProductsWithBrandAndCategorySpec()
    {
        Query.Include(p => p.Brand)
             .Include(p => p.Category);

        Query.Select(p => new ProductReadDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            ImageUrl = p.ImageUrl,
            Price = p.Price,
            Brand = new BrandReadDto
            {
                Id = p.Brand!.Id,
                Name = p.Brand!.Name
            },
            Category = new CategoryReadDto
            {
                Id = p.Category!.Id,
                Name = p.Category!.Name
            },
        });
    }
}
