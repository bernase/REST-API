using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[ApiController]
[Route("api/secure")]
public class SecureController : ControllerBase
{
    // Your secure endpoints here
}
