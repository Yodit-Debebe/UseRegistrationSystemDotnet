using Microsoft.AspNetCore.Mvc;
using UserRegistrationSystem.Application;

namespace UserRegistrationSystem.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly RegisterUserService _service;

    public UserController(RegisterUserService service)
    {
        _service = service;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        await _service.RegisterAsync(request.Email, request.Password);
        return Ok("User registered successfully");
    }
}

public record RegisterRequest(string Email, string Password);