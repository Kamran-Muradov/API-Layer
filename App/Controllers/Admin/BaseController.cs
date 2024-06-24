using Microsoft.AspNetCore.Mvc;

namespace App.Controllers.Admin
{
    [Route("api/admin[controller]/[action]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}
