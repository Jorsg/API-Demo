using DemoAPI.Common.Model;
using DemoAPI.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUserServices _userServices;

		public UsersController(IUserServices userServices)
		{
			_userServices = userServices;
		}

		// GET: api/<UsersController>
		
		[HttpGet(Name = "GetAll")]
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

		// GET api/<UsersController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<User>> Get(int id)
		{
			var result = await _userServices.Get(id);
			if (result == null)
			{
				return BadRequest();
			}
			else
				return Ok(result);
		}

		// POST api/<UsersController>
		[HttpPost]
		public async Task<ActionResult<User>> Post([FromBody] User user)
		{
			var result = await _userServices.Add(user);
			if (result == null)
			{
				return BadRequest();
			}
			else
				return Ok(result);
		}

		// PUT api/<UsersController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult<User>> Put(int id, [FromBody] User user)
		{
			var result = await _userServices.Update(user);
			if (result == null)
			{
				return BadRequest();
			}
			else
				return Ok(result);
		}

		// DELETE api/<UsersController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult<User>> Delete(int id)
		{
			var result = await _userServices.Delete(id);
			if (result == null)
			{
				return BadRequest();
			}
			else
				return Ok(result);
		}
	}
}
