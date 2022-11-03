# BlazorDevApp
### A demo app in Clean Architecture with Blazor WebAssembly

dotnet ef commands for managing database..
```
dotnet ef migrations add <name> -c AppDbContext -p src/BlazorDemoApp.Infrastructure -s src/BlazorDemoApp.Web -o Data/Migrations
dotnet ef migrations remove -c AppDbContext -p src/BlazorDemoApp.Infrastructure -s src/BlazorDemoApp.Web
dotnet ef database update -c AppDbContext -p src/BlazorDemoApp.Infrastructure -s src/BlazorDemoApp.Web
```
