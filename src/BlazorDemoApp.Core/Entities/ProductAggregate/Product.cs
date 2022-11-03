using Ardalis.GuardClauses;

using BlazorDemoApp.Core.Entities.BrandAggregate;
using BlazorDemoApp.Core.Entities.CategoryAggregate;
using BlazorDemoApp.Core.Interfaces;

namespace BlazorDemoApp.Core.Entities.ProductAggregate;
public class Product : EntityBase, IAggregateRoot
{
    public Product(string name, string description, decimal price, int brandId, int categoryId)
    {
        Guard.Against.NullOrEmpty(name, nameof(name));
        Guard.Against.NullOrEmpty(description, nameof(description));
        Guard.Against.NegativeOrZero(price, nameof(price));
        Guard.Against.NegativeOrZero(brandId, nameof(brandId));
        Guard.Against.NegativeOrZero(categoryId, nameof(categoryId));

        Name = name;
        Description = description;
        Price = price;
        BrandId = brandId;
        CategoryId = categoryId;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public string? ImageUrl { get; private set; }
    public decimal Price { get; private set; }
    public int BrandId { get; private set; }
    public int CategoryId { get; private set; }

    // navigation properties
    public Brand? Brand { get; set; }
    public Category? Category { get; set; }

    public void Update(string name, string description, decimal price, int brandId, int categoryId)
    {
        Guard.Against.NullOrEmpty(name, nameof(name));
        Guard.Against.NullOrEmpty(description, nameof(description));
        Guard.Against.NegativeOrZero(price, nameof(price));
        Guard.Against.NegativeOrZero(brandId, nameof(brandId));
        Guard.Against.NegativeOrZero(categoryId, nameof(categoryId));

        Name = name;
        Description = description;
        Price = price;
        BrandId = brandId;
        CategoryId = categoryId;
    }

    public void UpdateImageUrl(string imageUrl)
    {
        ImageUrl = imageUrl;
    }
}
