using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myfirstapi.Data;
using myfirstapi.Dtos.User;
using myfirstapi.Models;

namespace myfirstapi.Controllers
{
        [ApiController]
        [Route("[controller]")]
         public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;

        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new CharUser { UserName = request.Username }, request.Password
            );

            if(!response.success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(
                request.Username, request.Password
            );

            if(!response.success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}