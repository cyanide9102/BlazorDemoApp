using Ardalis.GuardClauses;
using Ardalis.Specification;

using BlazorDemoApp.SharedKernel.Dtos;

namespace BlazorDemoApp.Core.Entities.ProductAggregate.Specifications;
public class ProductByIdSpec : Specification<Product, ProductReadDto>, ISingleResultSpecification
{
    public ProductByIdSpec(int id)
    {
        Guard.Against.NegativeOrZero(id, nameof(id));

        Query.Include(p => p.Brand)
             .Include(p => p.Category)
             .Where(p => p.Id == id);

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
