using Microsoft.AspNetCore.Mvc;

namespace BlazorDemoApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
    public ApiControllerBase()
    {
    }
}
