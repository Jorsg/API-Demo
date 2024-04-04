using DemoAPI.Common.Model;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserServices _userServices;

		public UserController(IUserServices userServices)
		{
			_userServices = userServices;
		}

		
		[HttpGet]
		public async Task<ActionResult<IEnumerable<User>>> GetAll()
		{
			var result = await _userServices.GetAll();
			if (result == null)
			{
				return BadRequest();
			}
			else
				return Ok(result);
		}

		[HttpPost]
		public async Task<ActionResult<User>> CreateUser([FromBody] User user)
		{
			var result = await _userServices.Add(user);
			if (result == null)
			{
				return BadRequest();
			}
			else
				return Ok(result);
		}
	}
}
