# BlazorDevApp
### A demo app in Clean Architecture with Blazor WebAssembly

dotnet ef commands for managing database..
```
dotnet ef migrations add <name> -c AppDbContext -p src/BlazorDemoApp.Infrastructure -s src/BlazorDemoApp.Api -o Data/Migrations
dotnet ef migrations remove -c AppDbContext -p src/BlazorDemoApp.Infrastructure -s src/BlazorDemoApp.Api
dotnet ef database update -c AppDbContext -p src/BlazorDemoApp.Infrastructure -s src/BlazorDemoApp.Api
```
