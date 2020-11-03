using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIS_Production.Application.System.Users;
using SIS_Production.ViewModels.System.Users;
using System.Threading.Tasks;

namespace SIS_Production.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]

        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Authenticate(request);
            if (string.IsNullOrEmpty(result.ResultObj))
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Register(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetUserPagingRequest request)
        {
            var users = await _userService.GetUsersPaging(request);
            return Ok(users);
        }


    }
}
