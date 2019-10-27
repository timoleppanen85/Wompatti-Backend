using Microsoft.AspNetCore.Mvc;
using WompattiApi.Services;
using WompattiApi.Models;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<User> ReadUsers()
        {
            return new JsonResult(_userService.ReadUsers());
        }
    }
}