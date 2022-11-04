using System.Net.Http.Json;

using BlazorDemoApp.SharedKernel.Dtos;
using BlazorDemoApp.Web.Services.Contracts;

namespace BlazorDemoApp.Web.Services;
public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<ProductReadDto>?> GetProducts()
    {
        try
        {
            var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductReadDto>>("api/Products");
            return products;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<ProductReadDto?> GetProductById(int id)
    {
        try
        {
            var product = await _httpClient.GetFromJsonAsync<ProductReadDto>($"api/Product/{id}");
            return product;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
