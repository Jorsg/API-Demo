
namespace WebAppClient.Services
{
	public class UserService : IUserService
	{
		public async Task UrlApiUser(string url)
		{
			Uri baseAddreess = new Uri("https://localhost:5201/api/User");
		}
	}
}
