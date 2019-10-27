using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WompattiApi.Models;
using WompattiApi.Services;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public ActionResult<List<Admin>> ReadAdmins()
        {
            return new JsonResult(_adminService.ReadAdmins());
        }
    }
}