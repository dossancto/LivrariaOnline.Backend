using Microsoft.AspNetCore.Mvc;
using LivrariaOnline.Backend.Application.App.Users.UseCases;

namespace LivrariaOnline.Backend.UI.Controllers.Accounts.Users;

[ApiController]
[Route("[controller]")]
public partial class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly RegisterUserUseCase _registerUser;

    public UsersController(ILogger<UsersController> logger, RegisterUserUseCase registerUser)
    {
        _logger = logger;
        _registerUser = registerUser;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Deu good");
    }
}
