using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebAPI.BLL.DTO;
using WebAPI.BLL.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controler]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Add(AddUserDTO add)
        {

            try
            {
                _userService.AddUser(add);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();

        }

    }
}
