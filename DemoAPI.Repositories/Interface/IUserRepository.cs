using DemoAPI.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Repositories.Interface
{
	public interface IUserRepository
	{
		Task<IEnumerable<User>> GetAll();
		Task<User> Get(int id);
		Task<User> Add(User user);
		Task<User> Update(User user);
		Task<User> Delete(int id);



	}
}
