using DemoAPI.Common.Data;
using DemoAPI.Common.Model;
using DemoAPI.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly AgendaDbContext _context;

		public UserRepository(AgendaDbContext context)
		{
			_context = context;
		}
		public async Task<User> Add(User user)
		{
			var result = await _context.User.AddAsync(user);
			await _context.SaveChangesAsync();
			return result.Entity;
		}

		public Task<User> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<User> Get(int id)
		{
			var result = await _context.User.FindAsync(id);
			return result;
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			var result =  _context.User.AsEnumerable();
			return result;
		}

		public Task<User> Update(User user)
		{
			throw new NotImplementedException();
		}
	}
}
