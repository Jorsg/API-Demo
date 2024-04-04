using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppClient.Services;
using WebAppClient.Models;
using Newtonsoft.Json;

namespace WebAppClient.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		private readonly HttpClient _client;

		public UserController(IUserService userService, HttpClient client)
		{
			_userService = userService;
			_client = client;
		}

		
	}
}
