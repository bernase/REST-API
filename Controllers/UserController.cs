// Controllers/UserController.cs
using Microsoft.AspNetCore.Mvc;
using YourProjectName.Models;
using YourProjectName.Services;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    // CRUD operations
    // POST api/users/register
    [HttpPost("register")]
    public IActionResult Register([FromBody] UserDto userDto)
    {
        var result = _userService.Register(userDto);

        if (result.Success)
        {
            return Ok(new { Message = "User registered successfully" });
        }

        return BadRequest(new { Message = result.Message });
    }
}
