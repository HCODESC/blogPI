using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatformApi.Controllers;


[Route("api/[controller]/[action]")]
[ApiController]
public class UserController
{
    [HttpGet]
    public async Task<string> HelloApi()
    {
      return "Hello Api";   
    }
}