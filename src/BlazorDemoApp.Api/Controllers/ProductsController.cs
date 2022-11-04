using BlazorDemoApp.Core.Entities.ProductAggregate;
using BlazorDemoApp.Core.Entities.ProductAggregate.Specifications;
using BlazorDemoApp.Core.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace BlazorDemoApp.Api.Controllers;
public class ProductsController : ApiControllerBase
{
    private readonly IReadRepository<Product> _productRepository;

    public ProductsController(IReadRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        try
        {
            var productsWithBrandAndCategorySpecification = new ProductsWithBrandAndCategorySpec();
            var products = await _productRepository.ListAsync(productsWithBrandAndCategorySpecification);
            return Ok(products);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        try
        {
            var productByIdSpecification = new ProductByIdSpec(id);
            var product = await _productRepository.FirstOrDefaultAsync(productByIdSpecification);
            return product == null ? NotFound() : Ok(product);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
