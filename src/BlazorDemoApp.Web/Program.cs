using BlazorDemoApp.Web;
using BlazorDemoApp.Web.Services;
using BlazorDemoApp.Web.Services.Contracts;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IProductService, ProductService>(x => x.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"]!));

await builder.Build().RunAsync();
