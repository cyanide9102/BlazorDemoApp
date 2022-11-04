using BlazorDemoApp.SharedKernel.Dtos;

namespace BlazorDemoApp.Web.Services.Contracts;
public interface IProductService
{
    Task<IEnumerable<ProductReadDto>?> GetProducts();
    Task<ProductReadDto?> GetProductById(int id);
}
