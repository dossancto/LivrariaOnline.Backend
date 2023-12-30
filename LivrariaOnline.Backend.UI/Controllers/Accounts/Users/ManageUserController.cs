using Microsoft.AspNetCore.Mvc;
using LivrariaOnline.Backend.Application.App.Users.UseCases;

namespace LivrariaOnline.Backend.UI.Controllers.Accounts.Users;

public partial class UsersController : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterUserUseCase.SimpleRegister userDto)
    {
        var registeredUser = await _registerUser.Execute(userDto);
        return Ok(registeredUser);
    }
}
