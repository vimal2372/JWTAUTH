using Microsoft.AspNetCore.Mvc;

namespace _dotnetClaimAuthorization_.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public async Task<Object> RegisterUser(){
        
    }
    
}
