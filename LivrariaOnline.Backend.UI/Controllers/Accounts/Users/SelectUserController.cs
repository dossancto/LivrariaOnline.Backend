using Microsoft.AspNetCore.Mvc;
using LivrariaOnline.Backend.Application.App.Users.UseCases;

namespace LivrariaOnline.Backend.UI.Controllers.Accounts.Users;

public partial class UsersController : ControllerBase
{
    [HttpGet("me")]
    public IActionResult Me([FromBody] RegisterUserUseCase.SimpleRegister userDto)
    {
        return Ok("Deu good");
    }
}
