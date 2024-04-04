using DemoAPI.Common.Model;
using DemoAPI.Repositories.Interface;
using DemoAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Services
{
	public class UserServices : IUserServices
	{
		readonly IUserRepository _userRepository;
		public UserServices(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public Task<User> Add(User user)
		{
			if (user == null)
			{
				throw new ArgumentNullException(nameof(user));
			}
			return _userRepository.Add(user);
		}

		public Task<User> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Task<User> Get(int id)
		{
			if (id == null)
			{
				throw new ArgumentNullException(nameof(id));
			}
			return _userRepository.Get(id);
		}

		public Task<IEnumerable<User>> GetAll()
		{
			return _userRepository.GetAll();
		}

		public Task<User> Update(User user)
		{
			throw new NotImplementedException();
		}
	}
}
